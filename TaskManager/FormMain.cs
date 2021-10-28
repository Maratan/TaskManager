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
    public partial class FormMain : Form
    {
        private int userID;
        public FormMain(int id)
        {
            userID = id;
            InitializeComponent();
        }

        private void b_TaskCreate_Click(object sender, EventArgs e)
        {
            Hide();
            FormTaskCard form = new FormTaskCard(0);
            form.ShowDialog();
            Show();
        }

        private void b_TaskFilter_Click(object sender, EventArgs e)
        {
            Hide();
            FormFilter form = new FormFilter();
            form.ShowDialog();
            Show();
        }

        private void b_TaskEdit_Click(object sender, EventArgs e)
        {
            Hide();
            FormTaskCard form = new FormTaskCard(1);
            form.ShowDialog();
            Show();
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdm form = new FormAdm();
            form.ShowDialog();
            Show();
        }

        private void профильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfile form = new FormProfile(userID);
            form.ShowDialog();
        }
    }
}
