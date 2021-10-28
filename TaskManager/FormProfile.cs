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
    public partial class FormProfile : Form
    {
        int userID;
        public FormProfile(int id)
        {
            userID = id;
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            //загружаем данные
            string cmd = "SELECT login, first_name, last_name, department FROM users WHERE id = " + userID;

            List<string> userInfo = FuncsDB.SQLSelect(cmd, 4);

            c_Department.Text = userInfo[3].Trim(); //отдел

            t_FirstName.Text = userInfo[1].Trim(); //имя
            t_LastName.Text = userInfo[2].Trim(); //фамилия
            t_Login.Text = userInfo[0].Trim(); //логин 
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ChangePass_Click(object sender, EventArgs e)
        {

        }

        private void b_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
