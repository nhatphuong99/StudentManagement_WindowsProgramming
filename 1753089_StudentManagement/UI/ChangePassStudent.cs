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
    public partial class ChangePassStudent : Form
    {
        public string id;
        public ChangePassStudent()
        {
            InitializeComponent();
        }

        private void Logincancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Loginokbt_Click(object sender, EventArgs e)
        {
            if (idtb.Text == "" || idtb.Text != id || oldpasstb.Text == "" || newpasstb.Text == "")
            {
                MessageBox.Show("Change failed");
                return;
            }
            var bll = new BLL.BLL().ChangepassStudent(idtb.Text, oldpasstb.Text, newpasstb.Text);
            if (bll)
                MessageBox.Show("Change successed");
            else
                MessageBox.Show("Change failed");
           
            this.Close();

        }

        private void ChangePassStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            StudentMenu student = new StudentMenu();
            student.IDLabel.Text = student.IDLabel.Text + id;
            student.ShowDialog();
        }
    }
}
