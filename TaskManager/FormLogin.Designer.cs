namespace TaskManager
{
    partial class FormLogin
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
            this.b_Enter = new System.Windows.Forms.Button();
            this.b_Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Login = new System.Windows.Forms.TextBox();
            this.t_Pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_ShowPass = new System.Windows.Forms.CheckBox();
            this.t_LastName = new System.Windows.Forms.TextBox();
            this.l_LastName = new System.Windows.Forms.Label();
            this.t_FirstName = new System.Windows.Forms.TextBox();
            this.l_FirstName = new System.Windows.Forms.Label();
            this.l_Department = new System.Windows.Forms.Label();
            this.c_Department = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // b_Enter
            // 
            this.b_Enter.Location = new System.Drawing.Point(12, 244);
            this.b_Enter.Name = "b_Enter";
            this.b_Enter.Size = new System.Drawing.Size(260, 23);
            this.b_Enter.TabIndex = 0;
            this.b_Enter.Text = "Войти";
            this.b_Enter.UseVisualStyleBackColor = true;
            this.b_Enter.Click += new System.EventHandler(this.b_Enter_Click);
            // 
            // b_Registration
            // 
            this.b_Registration.Location = new System.Drawing.Point(12, 273);
            this.b_Registration.Name = "b_Registration";
            this.b_Registration.Size = new System.Drawing.Size(260, 23);
            this.b_Registration.TabIndex = 1;
            this.b_Registration.Text = "Зарегистрироваться";
            this.b_Registration.UseVisualStyleBackColor = true;
            this.b_Registration.Click += new System.EventHandler(this.b_Registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // t_Login
            // 
            this.t_Login.Location = new System.Drawing.Point(12, 29);
            this.t_Login.Name = "t_Login";
            this.t_Login.Size = new System.Drawing.Size(260, 20);
            this.t_Login.TabIndex = 3;
            // 
            // t_Pass
            // 
            this.t_Pass.Location = new System.Drawing.Point(12, 68);
            this.t_Pass.Name = "t_Pass";
            this.t_Pass.Size = new System.Drawing.Size(260, 20);
            this.t_Pass.TabIndex = 5;
            this.t_Pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // c_ShowPass
            // 
            this.c_ShowPass.AutoSize = true;
            this.c_ShowPass.Location = new System.Drawing.Point(12, 94);
            this.c_ShowPass.Name = "c_ShowPass";
            this.c_ShowPass.Size = new System.Drawing.Size(114, 17);
            this.c_ShowPass.TabIndex = 6;
            this.c_ShowPass.Text = "Показать пароль";
            this.c_ShowPass.UseVisualStyleBackColor = true;
            this.c_ShowPass.CheckedChanged += new System.EventHandler(this.c_ShowPass_CheckedChanged);
            // 
            // t_LastName
            // 
            this.t_LastName.Location = new System.Drawing.Point(12, 169);
            this.t_LastName.Name = "t_LastName";
            this.t_LastName.Size = new System.Drawing.Size(257, 20);
            this.t_LastName.TabIndex = 10;
            this.t_LastName.Visible = false;
            // 
            // l_LastName
            // 
            this.l_LastName.AutoSize = true;
            this.l_LastName.Location = new System.Drawing.Point(9, 153);
            this.l_LastName.Name = "l_LastName";
            this.l_LastName.Size = new System.Drawing.Size(59, 13);
            this.l_LastName.TabIndex = 9;
            this.l_LastName.Text = "Фамилия:";
            this.l_LastName.Visible = false;
            // 
            // t_FirstName
            // 
            this.t_FirstName.Location = new System.Drawing.Point(12, 130);
            this.t_FirstName.Name = "t_FirstName";
            this.t_FirstName.Size = new System.Drawing.Size(257, 20);
            this.t_FirstName.TabIndex = 8;
            this.t_FirstName.Visible = false;
            // 
            // l_FirstName
            // 
            this.l_FirstName.AutoSize = true;
            this.l_FirstName.Location = new System.Drawing.Point(9, 114);
            this.l_FirstName.Name = "l_FirstName";
            this.l_FirstName.Size = new System.Drawing.Size(32, 13);
            this.l_FirstName.TabIndex = 7;
            this.l_FirstName.Text = "Имя:";
            this.l_FirstName.Visible = false;
            // 
            // l_Department
            // 
            this.l_Department.AutoSize = true;
            this.l_Department.Location = new System.Drawing.Point(9, 192);
            this.l_Department.Name = "l_Department";
            this.l_Department.Size = new System.Drawing.Size(41, 13);
            this.l_Department.TabIndex = 11;
            this.l_Department.Text = "Отдел:";
            this.l_Department.Visible = false;
            // 
            // c_Department
            // 
            this.c_Department.FormattingEnabled = true;
            this.c_Department.Location = new System.Drawing.Point(12, 208);
            this.c_Department.Name = "c_Department";
            this.c_Department.Size = new System.Drawing.Size(257, 21);
            this.c_Department.TabIndex = 12;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.c_Department);
            this.Controls.Add(this.l_Department);
            this.Controls.Add(this.t_LastName);
            this.Controls.Add(this.l_LastName);
            this.Controls.Add(this.t_FirstName);
            this.Controls.Add(this.l_FirstName);
            this.Controls.Add(this.c_ShowPass);
            this.Controls.Add(this.t_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Registration);
            this.Controls.Add(this.b_Enter);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Enter;
        private System.Windows.Forms.Button b_Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Login;
        private System.Windows.Forms.TextBox t_Pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox c_ShowPass;
        private System.Windows.Forms.TextBox t_LastName;
        private System.Windows.Forms.Label l_LastName;
        private System.Windows.Forms.TextBox t_FirstName;
        private System.Windows.Forms.Label l_FirstName;
        private System.Windows.Forms.Label l_Department;
        private System.Windows.Forms.ComboBox c_Department;
    }
}