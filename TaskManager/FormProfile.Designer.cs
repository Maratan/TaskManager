namespace TaskManager
{
    partial class FormProfile
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
            this.pic_Avatar = new System.Windows.Forms.PictureBox();
            this.t_FirstName = new System.Windows.Forms.TextBox();
            this.t_LastName = new System.Windows.Forms.TextBox();
            this.t_Login = new System.Windows.Forms.TextBox();
            this.c_Department = new System.Windows.Forms.ComboBox();
            this.b_Edit = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_ChangePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Avatar
            // 
            this.pic_Avatar.Location = new System.Drawing.Point(12, 12);
            this.pic_Avatar.Name = "pic_Avatar";
            this.pic_Avatar.Size = new System.Drawing.Size(200, 200);
            this.pic_Avatar.TabIndex = 0;
            this.pic_Avatar.TabStop = false;
            // 
            // t_FirstName
            // 
            this.t_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_FirstName.Location = new System.Drawing.Point(12, 262);
            this.t_FirstName.Name = "t_FirstName";
            this.t_FirstName.Size = new System.Drawing.Size(200, 26);
            this.t_FirstName.TabIndex = 1;
            this.t_FirstName.Text = "Имя";
            // 
            // t_LastName
            // 
            this.t_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_LastName.Location = new System.Drawing.Point(12, 294);
            this.t_LastName.Name = "t_LastName";
            this.t_LastName.Size = new System.Drawing.Size(200, 26);
            this.t_LastName.TabIndex = 2;
            this.t_LastName.Text = "Фамилия";
            // 
            // t_Login
            // 
            this.t_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_Login.Location = new System.Drawing.Point(12, 326);
            this.t_Login.Name = "t_Login";
            this.t_Login.Size = new System.Drawing.Size(200, 26);
            this.t_Login.TabIndex = 3;
            this.t_Login.Text = "Логин";
            // 
            // c_Department
            // 
            this.c_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_Department.FormattingEnabled = true;
            this.c_Department.Location = new System.Drawing.Point(12, 218);
            this.c_Department.Name = "c_Department";
            this.c_Department.Size = new System.Drawing.Size(200, 28);
            this.c_Department.TabIndex = 5;
            // 
            // b_Edit
            // 
            this.b_Edit.Location = new System.Drawing.Point(12, 390);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(200, 23);
            this.b_Edit.TabIndex = 6;
            this.b_Edit.Text = "Редактировать";
            this.b_Edit.UseVisualStyleBackColor = true;
            this.b_Edit.Click += new System.EventHandler(this.b_Edit_Click);
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(12, 419);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(200, 23);
            this.b_Close.TabIndex = 7;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_ChangePass
            // 
            this.b_ChangePass.Location = new System.Drawing.Point(12, 361);
            this.b_ChangePass.Name = "b_ChangePass";
            this.b_ChangePass.Size = new System.Drawing.Size(200, 23);
            this.b_ChangePass.TabIndex = 8;
            this.b_ChangePass.Text = "Сменить пароль";
            this.b_ChangePass.UseVisualStyleBackColor = true;
            this.b_ChangePass.Click += new System.EventHandler(this.b_ChangePass_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 453);
            this.Controls.Add(this.b_ChangePass);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.c_Department);
            this.Controls.Add(this.t_Login);
            this.Controls.Add(this.t_LastName);
            this.Controls.Add(this.t_FirstName);
            this.Controls.Add(this.pic_Avatar);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Avatar;
        private System.Windows.Forms.TextBox t_FirstName;
        private System.Windows.Forms.TextBox t_LastName;
        private System.Windows.Forms.TextBox t_Login;
        private System.Windows.Forms.ComboBox c_Department;
        private System.Windows.Forms.Button b_Edit;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_ChangePass;
    }
}