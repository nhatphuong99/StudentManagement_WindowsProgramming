using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ChangePassTeacher : Form
    {
        public ChangePassTeacher()
        {
            InitializeComponent();
        }


        private void ChangePassTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            TeacherMenu teacher = new TeacherMenu();
            teacher.ShowDialog();
        }

        private void changecancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeokbt_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "" || oldpasstb.Text == "" || newpasstb.Text == "")
            {
                MessageBox.Show("Change failed");
                return;
            }
            var bll = new BLL.BLL().ChangepassTeaCher(idtb.Text, oldpasstb.Text, newpasstb.Text);
            if (bll)
            {
                MessageBox.Show("Change successed");
                this.Close();
            }
            else
                MessageBox.Show("Change failed");
          
        }
    }
}
