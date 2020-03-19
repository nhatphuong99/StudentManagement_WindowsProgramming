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
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }


        public Label IDLabel
        {
            get { return idlb; }
            set { idlb = value; }
        }

        private void Changepassbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassStudent change = new ChangePassStudent();
            string[] temp = idlb.Text.Split((":").ToCharArray());
            change.id = temp[1];
            change.ShowDialog();
            this.Close();
        }

        private void Viewscorebttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            string[] temp = idlb.Text.Split((":").ToCharArray());
            StudentViewScore viewscore = new StudentViewScore(temp[1]);
            viewscore.ShowDialog();
            this.Close();
        }
    }
}
