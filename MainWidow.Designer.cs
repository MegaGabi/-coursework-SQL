namespace El_store
{
    partial class MainWidow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWidow));
            this.ms_Main = new System.Windows.Forms.MenuStrip();
            this.tsm_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Dirrector = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Emploees = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AddEmploee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DeleteEmploee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Accountant = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Sells = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_GetMoneyByMonthYear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Seller = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_EditDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_Electronics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AddElectronics = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_EditElectronics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_AddCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_EditDeleteCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.p_ContentHolder = new System.Windows.Forms.Panel();
            this.ms_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.p_ContentHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Main
            // 
            this.ms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Admin,
            this.tsm_Dirrector,
            this.tsm_Accountant,
            this.tsm_Seller,
            this.tsmi_Exit});
            this.ms_Main.Location = new System.Drawing.Point(0, 0);
            this.ms_Main.Name = "ms_Main";
            this.ms_Main.Size = new System.Drawing.Size(1092, 24);
            this.ms_Main.TabIndex = 0;
            this.ms_Main.Text = "menuStrip1";
            // 
            // tsm_Admin
            // 
            this.tsm_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Users,
            this.toolStripMenuItem1,
            this.tsmi_AddUser,
            this.tsmi_DeleteUser});
            this.tsm_Admin.Name = "tsm_Admin";
            this.tsm_Admin.Size = new System.Drawing.Size(106, 20);
            this.tsm_Admin.Text = "Администратор";
            // 
            // tsmi_Users
            // 
            this.tsmi_Users.Name = "tsmi_Users";
            this.tsmi_Users.Size = new System.Drawing.Size(204, 22);
            this.tsmi_Users.Text = "Пользователи";
            this.tsmi_Users.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 6);
            // 
            // tsmi_AddUser
            // 
            this.tsmi_AddUser.Name = "tsmi_AddUser";
            this.tsmi_AddUser.Size = new System.Drawing.Size(204, 22);
            this.tsmi_AddUser.Text = "Добавить пользователя";
            this.tsmi_AddUser.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsmi_DeleteUser
            // 
            this.tsmi_DeleteUser.Name = "tsmi_DeleteUser";
            this.tsmi_DeleteUser.Size = new System.Drawing.Size(204, 22);
            this.tsmi_DeleteUser.Text = "Удалить пользователя";
            this.tsmi_DeleteUser.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsm_Dirrector
            // 
            this.tsm_Dirrector.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Emploees,
            this.toolStripMenuItem2,
            this.tsmi_AddEmploee,
            this.tsmi_DeleteEmploee});
            this.tsm_Dirrector.Name = "tsm_Dirrector";
            this.tsm_Dirrector.Size = new System.Drawing.Size(72, 20);
            this.tsm_Dirrector.Text = "Директор";
            // 
            // tsmi_Emploees
            // 
            this.tsmi_Emploees.Name = "tsmi_Emploees";
            this.tsmi_Emploees.Size = new System.Drawing.Size(241, 22);
            this.tsmi_Emploees.Text = "Сотрудники";
            this.tsmi_Emploees.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 6);
            // 
            // tsmi_AddEmploee
            // 
            this.tsmi_AddEmploee.Name = "tsmi_AddEmploee";
            this.tsmi_AddEmploee.Size = new System.Drawing.Size(241, 22);
            this.tsmi_AddEmploee.Text = "Добавить сотрудника";
            this.tsmi_AddEmploee.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsmi_AddEmploee.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsmi_DeleteEmploee
            // 
            this.tsmi_DeleteEmploee.Name = "tsmi_DeleteEmploee";
            this.tsmi_DeleteEmploee.Size = new System.Drawing.Size(241, 22);
            this.tsmi_DeleteEmploee.Text = "Удалить/изменить сотрудника";
            this.tsmi_DeleteEmploee.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsm_Accountant
            // 
            this.tsm_Accountant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Sells,
            this.toolStripMenuItem3,
            this.tsmi_GetMoneyByMonthYear});
            this.tsm_Accountant.Name = "tsm_Accountant";
            this.tsm_Accountant.Size = new System.Drawing.Size(73, 20);
            this.tsm_Accountant.Text = "Бухгалтер";
            // 
            // tsmi_Sells
            // 
            this.tsmi_Sells.Name = "tsmi_Sells";
            this.tsmi_Sells.Size = new System.Drawing.Size(176, 22);
            this.tsmi_Sells.Text = "Продажи";
            this.tsmi_Sells.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(173, 6);
            // 
            // tsmi_GetMoneyByMonthYear
            // 
            this.tsmi_GetMoneyByMonthYear.Name = "tsmi_GetMoneyByMonthYear";
            this.tsmi_GetMoneyByMonthYear.Size = new System.Drawing.Size(176, 22);
            this.tsmi_GetMoneyByMonthYear.Text = "Продажи за месяц";
            this.tsmi_GetMoneyByMonthYear.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsm_Seller
            // 
            this.tsm_Seller.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Customers,
            this.toolStripMenuItem4,
            this.tsmi_AddCustomer,
            this.tsmi_EditDeleteCustomer,
            this.toolStripMenuItem6,
            this.tsmi_Electronics,
            this.toolStripMenuItem5,
            this.tsmi_AddElectronics,
            this.tsmi_EditElectronics,
            this.toolStripMenuItem7,
            this.tsmi_AddCheck,
            this.tsmi_EditDeleteCheck});
            this.tsm_Seller.Name = "tsm_Seller";
            this.tsm_Seller.Size = new System.Drawing.Size(73, 20);
            this.tsm_Seller.Text = "Продавец";
            // 
            // tsmi_Customers
            // 
            this.tsmi_Customers.Name = "tsmi_Customers";
            this.tsmi_Customers.Size = new System.Drawing.Size(248, 22);
            this.tsmi_Customers.Text = "Покупатели";
            this.tsmi_Customers.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmi_AddCustomer
            // 
            this.tsmi_AddCustomer.Name = "tsmi_AddCustomer";
            this.tsmi_AddCustomer.Size = new System.Drawing.Size(248, 22);
            this.tsmi_AddCustomer.Text = "Добавить покупателя";
            this.tsmi_AddCustomer.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsmi_EditDeleteCustomer
            // 
            this.tsmi_EditDeleteCustomer.Name = "tsmi_EditDeleteCustomer";
            this.tsmi_EditDeleteCustomer.Size = new System.Drawing.Size(248, 22);
            this.tsmi_EditDeleteCustomer.Text = "Удалить/изменить покупателя";
            this.tsmi_EditDeleteCustomer.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmi_Electronics
            // 
            this.tsmi_Electronics.Name = "tsmi_Electronics";
            this.tsmi_Electronics.Size = new System.Drawing.Size(248, 22);
            this.tsmi_Electronics.Text = "Электроника";
            this.tsmi_Electronics.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmi_AddElectronics
            // 
            this.tsmi_AddElectronics.Name = "tsmi_AddElectronics";
            this.tsmi_AddElectronics.Size = new System.Drawing.Size(248, 22);
            this.tsmi_AddElectronics.Text = "Добавить электронику";
            this.tsmi_AddElectronics.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsmi_EditElectronics
            // 
            this.tsmi_EditElectronics.Name = "tsmi_EditElectronics";
            this.tsmi_EditElectronics.Size = new System.Drawing.Size(248, 22);
            this.tsmi_EditElectronics.Text = "Удалить/изменить электронику";
            this.tsmi_EditElectronics.Click += new System.EventHandler(this.ProcessClick);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(245, 6);
            // 
            // tsmi_AddCheck
            // 
            this.tsmi_AddCheck.Name = "tsmi_AddCheck";
            this.tsmi_AddCheck.Size = new System.Drawing.Size(248, 22);
            this.tsmi_AddCheck.Text = "Добавить чек";
            this.tsmi_AddCheck.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsmi_EditDeleteCheck
            // 
            this.tsmi_EditDeleteCheck.Name = "tsmi_EditDeleteCheck";
            this.tsmi_EditDeleteCheck.Size = new System.Drawing.Size(248, 22);
            this.tsmi_EditDeleteCheck.Text = "Удалить/изменить чек";
            this.tsmi_EditDeleteCheck.Click += new System.EventHandler(this.ProcessClick);
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(53, 20);
            this.tsmi_Exit.Text = "Выход";
            this.tsmi_Exit.Click += new System.EventHandler(this.ProcessClick);
            // 
            // dgv_Data
            // 
            this.dgv_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(3, 3);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(1086, 494);
            this.dgv_Data.TabIndex = 1;
            // 
            // p_ContentHolder
            // 
            this.p_ContentHolder.Controls.Add(this.dgv_Data);
            this.p_ContentHolder.Location = new System.Drawing.Point(0, 27);
            this.p_ContentHolder.Name = "p_ContentHolder";
            this.p_ContentHolder.Size = new System.Drawing.Size(1092, 573);
            this.p_ContentHolder.TabIndex = 2;
            // 
            // MainWidow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 601);
            this.Controls.Add(this.p_ContentHolder);
            this.Controls.Add(this.ms_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_Main;
            this.Name = "MainWidow";
            this.Text = "Магазин электроники";
            this.ms_Main.ResumeLayout(false);
            this.ms_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.p_ContentHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Main;
        private System.Windows.Forms.ToolStripMenuItem tsm_Admin;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Users;
        private System.Windows.Forms.ToolStripMenuItem tsm_Dirrector;
        private System.Windows.Forms.ToolStripMenuItem tsm_Accountant;
        private System.Windows.Forms.ToolStripMenuItem tsm_Seller;
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Panel p_ContentHolder;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Emploees;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Sells;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Customers;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Electronics;
        private System.Windows.Forms.ToolStripMenuItem tsmi_GetMoneyByMonthYear;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddUser;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddEmploee;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteEmploee;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmi_EditDeleteCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddElectronics;
        private System.Windows.Forms.ToolStripMenuItem tsmi_EditElectronics;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddCheck;
        private System.Windows.Forms.ToolStripMenuItem tsmi_EditDeleteCheck;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    }
}

