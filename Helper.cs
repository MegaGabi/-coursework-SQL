using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace El_store
{
    public class SQL_Helper
    {
        public class Parameter
        {
            public Parameter()
            { }
            public Parameter(string n, dynamic val)
            {
                name = n;
                value = val;
                type = val.GetType();
            }
            public Parameter(dynamic val)
            {
                name = null;
                value = val;
                type = val.GetType();
            }
            public Parameter(string n, Type t)
            {
                name = n;
                value = null;
                type = t;
            }

            public string   name;
            public Type     type;
            public object   value;
        }

        private static  Dictionary<Type, SqlDbType> typeMap; //все типы из C# соответствующие типам из SQL

        private static  SQL_Helper                  instance; //синглтон
        public  static  SqlConnection               con;

        private SQL_Helper()
        {
            con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["El_store.Properties.Settings.connString"].ConnectionString;
            if (con.ConnectionString == null)
                MessageBox.Show("Строка соединения с базой данных не верна!", "Ошибака!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            FillDataMap();
        }

        public static SQL_Helper getInstance()
        {
            if (instance == null)
                instance = new SQL_Helper();
            return instance;
        }

        public void FillDataMap()
        {
            typeMap = new Dictionary<Type, SqlDbType>();

            typeMap[typeof(string)] = SqlDbType.NVarChar;
            typeMap[typeof(byte)] = SqlDbType.TinyInt;
            typeMap[typeof(short)] = SqlDbType.SmallInt;
            typeMap[typeof(int)] = SqlDbType.Int;
            typeMap[typeof(long)] = SqlDbType.BigInt;
            typeMap[typeof(byte[])] = SqlDbType.Image;
            typeMap[typeof(bool)] = SqlDbType.Bit;
            typeMap[typeof(DateTime)] = SqlDbType.DateTime2;
            typeMap[typeof(DateTimeOffset)] = SqlDbType.DateTimeOffset;
            typeMap[typeof(decimal)] = SqlDbType.Money;
            typeMap[typeof(float)] = SqlDbType.Real;
            typeMap[typeof(double)] = SqlDbType.Float;
            typeMap[typeof(TimeSpan)] = SqlDbType.Time;
        }

        public DataTable SQL_view(string viewName)
        {
            SqlCommand comm = new SqlCommand("Select * FROM " + viewName, con);

            con.Open();

            SqlDataReader dr = comm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            con.Close();

            return dt;
        }

        public Parameter[] ProcedureParameters(string functionName, bool Order = false)
        {
            List<Parameter> parameters = new List<Parameter>();

            string command = "SELECT * FROM GetFunctionArguments(@p1)";
            if (Order == true)
                command += " order by [param]";
            SqlCommand comm = new SqlCommand(command, con);

            comm.Parameters.AddWithValue("@p1", functionName);

            con.Open();

            SqlDataReader dr = comm.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //перевод строки названия типа SQL в тип C#
                string st = dt.Rows[i][1].ToString();
                SqlDbType e = (SqlDbType)Enum.Parse(typeof(SqlDbType), st, true);
                Type t = typeMap.First(x => x.Value == e).Key;

                parameters.Add(new Parameter(dt.Rows[i][0].ToString(), t));
            }

            con.Close();

            return parameters.ToArray();
        }

        public Parameter SQL_Scalarfunction(string functionName, params Parameter[] parameters)
        {
            Parameter ret = new Parameter();

            functionName = "SELECT " + functionName;
            functionName += "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].name != "")
                {
                    functionName += parameters[i].name;
                    if (i != parameters.Length - 1)
                        functionName += ", ";
                }
                else
                    ret = parameters[i];
            }
            functionName += ")";

            SqlCommand comm = new SqlCommand(functionName, con);
            comm.CommandType = CommandType.Text;

            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].name != "")
                {
                    comm.Parameters.AddWithValue(parameters[i].name, parameters[i].value);
                }
            }

            con.Open();

            ret.value = comm.ExecuteScalar();

            con.Close();

            return ret;
        }

        public Parameter SQL_StoredProcedure(string functionName, params Parameter[] parameters)
        {
            Parameter ret = new Parameter();

            SqlCommand comm = new SqlCommand(functionName, con);
            comm.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].name != "")
                {
                    comm.Parameters.AddWithValue(parameters[i].name, parameters[i].value);
                }
            }

            con.Open();

            comm.ExecuteNonQuery();

            con.Close();

            return ret;
        }

        public DataTable SQL_Tablefunction(string functionName, params Parameter[] parameters)
        {
            DataTable ret = new DataTable();

            functionName = "SELECT * FROM " + functionName;
            functionName += "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].name != "")
                {
                    functionName += parameters[i].name;
                    if (i != parameters.Length - 1)
                        functionName += ", ";
                }
            }
            functionName += ")";

            SqlCommand comm = new SqlCommand(functionName, con);
            comm.CommandType = CommandType.Text;

            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i].name != "")
                {
                    comm.Parameters.AddWithValue(parameters[i].name, parameters[i].value);
                }
            }

            con.Open();

            SqlDataReader dr = comm.ExecuteReader();
            ret.Load(dr);

            con.Close();

            return ret;
        }

        public DataTable SQL_ExecuteQuery(string functionName)
        {
            DataTable ret = new DataTable();

            SqlCommand comm = new SqlCommand(functionName, con);
            comm.CommandType = CommandType.Text;

            con.Open();

            SqlDataReader dr = comm.ExecuteReader();
            ret.Load(dr);

            con.Close();

            return ret;
        }

        public void CloseConnection()
        {
            con.Close();
        }
    }
}
