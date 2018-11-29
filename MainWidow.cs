using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using El_store.Controlls.Users;
using El_store.Controlls.Emploees;
using El_store.Controlls.Customers;
using El_store.Controlls.Electronics;
using El_store.Controlls.Sells;

namespace El_store
{
    public partial class MainWidow : Form
    {
        public enum Access { Admin = 1, Dirrector, Emploee, Accountant};
        private Access access;

        ProcedureControll pc;

        SQL_Helper.Parameter pc_scalar_res;
        ProcedureControll.FncType fnc_Type;//тип функции

        public MainWidow(Access acss)
        {
            InitializeComponent();

            SQL_Helper.getInstance();//установка синглтона из нулл в нормальное состояние

            access = acss;

            //регулировка уровней доступа
            if (access != Access.Admin)
            {
                tsm_Admin.Visible = false;
                if (access != Access.Dirrector)
                {
                    tsm_Dirrector.Visible = false;
                    if (access != Access.Accountant)
                    {
                        tsm_Accountant.Visible = false;
                    }
                    else if (access != Access.Emploee)
                    {
                        tsm_Seller.Visible = false;
                    }
                }
            }
        }

        private void ProcessClick(object sender, EventArgs e)
        {
            ResetWindow();

            if (tsmi_Users == sender)
            {
                DataTable dt = SQL_Helper.getInstance().SQL_view("[dbo].[FullUserInfo]");
                dgv_Data.DataSource = dt;
            }
            else if (tsmi_Electronics == sender)
            {
                DataTable dt = SQL_Helper.getInstance().SQL_view("[dbo].[Products]");
                dgv_Data.DataSource = dt;
            }
            else if (tsmi_Emploees == sender)
            {
                DataTable dt = SQL_Helper.getInstance().SQL_view("[dbo].[FullEmploeeInfo]");
                dgv_Data.DataSource = dt;
            }
            else if (tsmi_Sells == sender)
            {
                var buf_p = SQL_Helper.getInstance().ProcedureParameters("FullSellInfoFunc");
                DataTable dt = SQL_Helper.getInstance().SQL_Tablefunction("[dbo].[FullSellInfoFunc]", buf_p);
                dgv_Data.DataSource = dt;
            }
            else if (tsmi_Customers == sender)
            {
                DataTable dt = SQL_Helper.getInstance().SQL_view("[dbo].[FullCustomerInfo]");
                dgv_Data.DataSource = dt;
            }
            else if (tsmi_GetMoneyByMonthYear == sender)
            {
                var buf_p = SQL_Helper.getInstance().ProcedureParameters("MoneyFromMonthes", true);
                ProcedureControllCreate("dbo.MoneyFromMonthes", ProcedureControll.FncType.Table, buf_p);
                pc.SetLabels("Первый месяц", "Последний месяц", "Год");
            }
            else if (tsmi_AddUser == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                AddUserControll auc = new AddUserControll();

                try
                {
                    p_ContentHolder.Controls.Add(auc);
                    auc.sendMessage += new AddUserControll.SendMessage(GetMessageLight);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (tsmi_DeleteUser == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                DeleteUser auc = new DeleteUser();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new DeleteUser.SendMessage(GetMessageLight);
            }
            else if (tsmi_AddEmploee == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                AddEmploeeControll auc = new AddEmploeeControll();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new AddEmploeeControll.SendMessage(GetMessageLight);
            }
            else if (tsmi_DeleteEmploee == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                DeleteEmploee auc = new DeleteEmploee();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new DeleteEmploee.SendMessage(GetMessageLight);
            }
            else if (tsmi_AddCustomer == sender)
            {
                var buf_p = SQL_Helper.getInstance().ProcedureParameters("Add_Customer_Procedure", true);
                ProcedureControllCreate("dbo.Add_Customer_Procedure", ProcedureControll.FncType.StoredProcedure, buf_p);
                pc.SetLabels("Фамилия", "Имя", "Отчество", "Телефон");
            }
            else if (tsmi_EditDeleteCustomer == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                DeleteCustomer auc = new DeleteCustomer();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new DeleteCustomer.SendMessage(GetMessageLight);
            }
            else if (tsmi_AddElectronics == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                AddElectronics auc = new AddElectronics();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new AddElectronics.SendMessage(GetMessageLight);
            }
            else if (tsmi_EditElectronics == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                DelEditElectronics auc = new DelEditElectronics();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new DelEditElectronics.SendMessage(GetMessageLight);
            }
            else if (tsmi_AddCheck == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                AddCheck auc = new AddCheck();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new AddCheck.SendMessage(GetMessageLight);
            }
            else if (tsmi_EditDeleteCheck == sender)
            {
                dgv_Data.Visible = false;
                dgv_Data.Enabled = false;

                EditDeleteCheck auc = new EditDeleteCheck();

                p_ContentHolder.Controls.Add(auc);
                auc.sendMessage += new EditDeleteCheck.SendMessage(GetMessageLight);
            }
            else if (tsmi_Exit == sender)
            {
                this.Hide();
                Login l = new Login();
                l.ShowDialog();
                this.Close();
            }
        }

        private void ProcedureControllCreate(string pName, ProcedureControll.FncType type,  SQL_Helper.Parameter[] buf_p)
        {
            dgv_Data.Visible = false;
            dgv_Data.Enabled = false;

            pc = new ProcedureControll(pName, buf_p);
            pc.Function_Type = type;

            pc.sendMessage += new ProcedureControll.SendMessage(GetMessage);
            
            pc.Size = p_ContentHolder.Size;
            p_ContentHolder.Controls.Add(pc);
        }

        private void GetMessageLight()
        {
            

            dgv_Data.Visible = true;
            dgv_Data.Enabled = true;

        }

        private void GetMessage()
        {
            var p = pc.parameters;

            if (pc.Function_Type == ProcedureControll.FncType.Scalar)
            {
                SQL_Helper.Parameter res = new SQL_Helper.Parameter();
                try
                {
                    res = SQL_Helper.getInstance().SQL_Scalarfunction(pc.ProcedureName, p);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                Type t = res.type;

                pc_scalar_res = new SQL_Helper.Parameter();
                pc_scalar_res.value = res;
                pc_scalar_res.type = t;
            }
            else if (pc.Function_Type == ProcedureControll.FncType.Table)
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = SQL_Helper.getInstance().SQL_Tablefunction(pc.ProcedureName, p);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                dgv_Data.DataSource = dt;
            }
            else if (pc.Function_Type == ProcedureControll.FncType.StoredProcedure)
            {
                SQL_Helper.getInstance().SQL_StoredProcedure(pc.ProcedureName, p);
            }
            fnc_Type = pc.Function_Type;

            ResetWindow();
        }

        private void ResetWindow()
        {
            dgv_Data.Visible = true;
            dgv_Data.Enabled = true;

            var disp = p_ContentHolder.Controls.IndexOf(dgv_Data);

            for (int i = 0; i < p_ContentHolder.Controls.Count;)
            {
                if (i != disp)
                {
                    p_ContentHolder.Controls[i].Dispose();
                }
                else
                    i++;
            }
        }
    }
}
