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
    public partial class FormTaskCard : Form
    {
        public FormTaskCard(int id)
        {
            InitializeComponent();

            //анализируем режим открытия окна (если 0, то режим создания задачи)
            if (id != 0)
                downloadTask(id);
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //подгружаем данные задачи
        private void downloadTask(int id)
        {
        }
    }
}
