using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        bool Registration = false;

        //регистрация
        private void b_Registration_Click(object sender, EventArgs e)
        {
            if (!Registration)
            {
                //показываем поля для заполнения информации
                l_FirstName.Visible = true;
                t_FirstName.Visible = true;

                l_LastName.Visible = true;
                t_LastName.Visible = true;

                l_Department.Visible = true;
                c_Department.Visible = true;

                Registration = true;
            }
            else
            {
                FuncsMain.User user = new FuncsMain.User(t_Login.Text, t_Pass.Text, t_FirstName.Text, t_LastName.Text, c_Department.Text);
                if (!FuncsMain.UserReg(user))
                {
                    MessageBox.Show("Данный логин уже существует, пожалуйста, придумайте другой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //добавляем нового пользователя и выполняем вход
                if (CheckTextBox("reg"))
                {
                    int userID = FuncsMain.Auth(user);

                    if (userID == -1)
                    {
                        MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    OpenSession(userID);
                }

            }
        }

        //авторизация
        private void b_Enter_Click(object sender, EventArgs e)
        {
            //проверка на заполнение полей
            if (!CheckTextBox())
            {
                MessageBox.Show("Незаполнены логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FuncsMain.Auth(new FuncsMain.User(t_Login.Text, t_Pass.Text)) == -1)
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userID = FuncsMain.Auth(new FuncsMain.User(t_Login.Text, t_Pass.Text));

            OpenSession(userID);
        }

        //авторизация
        private void OpenSession(int id)
        {
            Hide();
            FormMain form = new FormMain(id);
            form.ShowDialog();
        }

        //проверка на заполнение полей
        private bool CheckTextBox(string mode = "")
        {
            if (t_Login.Text.Trim() == "") //логин
            {
                MessageBox.Show("Не заполнено поле 'Логин'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (t_Pass.Text.Trim() == "") //пароль
            {
                MessageBox.Show("Не заполнено поле 'Пароль'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (mode.ToLower() == "reg")
            {
                if (t_FirstName.Text.Trim() == "") //Имя
                {
                    MessageBox.Show("Не заполнено поле 'Имя'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (t_LastName.Text.Trim() == "") //Фамилия
                {
                    MessageBox.Show("Не заполнено поле 'Пароль'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (c_Department.Text.Trim() == "") //Отдел
                {
                    MessageBox.Show("Не заполнено поле 'Отдел'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        //показать пароль
        private void c_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (c_ShowPass.Checked)
                t_Pass.UseSystemPasswordChar = false;
            else
                t_Pass.UseSystemPasswordChar = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //подгружаем списки отделов
            foreach (string el in FuncsMain.DepartmentList())
                c_Department.Items.Add(el);
        }
    }
}
