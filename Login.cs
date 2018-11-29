using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var buf_p = SQL_Helper.getInstance().ProcedureParameters("Login_Function");
            buf_p[1].value = tb_login.Text;
            buf_p[2].value = tb_password.Text;
            SQL_Helper.Parameter dt = SQL_Helper.getInstance().SQL_Scalarfunction("[dbo].[Login_Function]", buf_p);

            MainWidow.Access? acs = null;

            if (!(dt.value is  DBNull))
            {
                int val = Convert.ToInt32(dt.value);

                DataTable d = SQL_Helper.getInstance().SQL_ExecuteQuery("SELECT Role FROM users WHERE userID = " + val);

                if (d.Rows.Count > 0)
                {
                    val = (int)d.Rows[0][0];

                    if (val == (int)MainWidow.Access.Admin)
                    {
                        acs = MainWidow.Access.Admin;
                    }
                    else if (val == (int)MainWidow.Access.Accountant)
                    {
                        acs = MainWidow.Access.Accountant;
                    }
                    else if (val == (int)MainWidow.Access.Emploee)
                    {
                        acs = MainWidow.Access.Emploee;
                    }
                    else if (val == (int)MainWidow.Access.Dirrector)
                    {
                        acs = MainWidow.Access.Dirrector;
                    }
                }
            }

            if (acs == null)
            {
                MessageBox.Show("Ошибка! Пользователя с такими данными не существует!");
                return;
            }

            this.Hide();
            MainWidow mw = new MainWidow((MainWidow.Access)acs);
            mw.ShowDialog();
            this.Close();
        }
    }
}
