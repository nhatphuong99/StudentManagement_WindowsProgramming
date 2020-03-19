using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Logincancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginokbt_Click(object sender, EventArgs e)
        {
            var usrn = usernametb.Text;
            var pass = passtb.Text;
            int check = new BLL.BLL().CheckLogin(usrn, pass);

            
            if (check == 1)
            {
                this.Hide();
                StudentMenu student = new StudentMenu();
                student.IDLabel.Text = student.IDLabel.Text + usrn;
                student.ShowDialog();
                this.Close();
            }
            else if (check == 2)
            {
                this.Hide();
                TeacherMenu teacher = new TeacherMenu();
                teacher.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Wrong username or password!");

        }
    }

}
