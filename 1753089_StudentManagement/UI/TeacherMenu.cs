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
    public partial class TeacherMenu : Form
    {
        public TeacherMenu()
        {
            InitializeComponent();
        }

        private void Importstulist_Click(object sender, EventArgs e)
        {
            var bll = new BLL.BLL();
            var o = openFile.ShowDialog();
            string path = "";
            if (o == DialogResult.OK)
                path = openFile.FileName;
            if (path == "")
                return;
            var students = bll.ReadStudentsFromFile(path);
            var check = bll.ImportStudentsFromListStudent(students);
            if (check)
                MessageBox.Show("Import sucessed!");
            else
                MessageBox.Show("Import failed!");
        }

        private void Logoutbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            this.Close();
        }

        private void Viewstulist_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudentList viewstu = new ViewStudentList();
            viewstu.ShowDialog();
            this.Close();
        }

        private void Changepassbttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassTeacher change = new ChangePassTeacher();
            change.ShowDialog();
            this.Close();
        }

        private void Addstu_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent add = new AddStudent();
            add.ShowDialog();
            this.Close();
        }

        private void Importschedule_Click(object sender, EventArgs e)
        {
            var bll = new BLL.BLL();
            var o = openFile.ShowDialog();
            string path = "";
            if (o == DialogResult.OK)
                path = openFile.FileName;
            if (path == "")
                return;
            var schedule = bll.ReadScheduleFromFile(path);
            var check = bll.ImportSchedules(schedule);
            if (check)
                MessageBox.Show("Import sucessed!");
            else
                MessageBox.Show("Import failed!");
        }

        private void Viewschedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSchedule viewsche = new ViewSchedule();
            viewsche.ShowDialog();
            this.Close();
        }

        private void Importscorebttn_Click(object sender, EventArgs e)
        {
            var bll = new BLL.BLL();
            var o = openFile.ShowDialog();
            string path = "";
            if (o == DialogResult.OK)
                path = openFile.FileName;
            if (path == "")
                return;
            var scores = bll.ReadScoreboardFromFile(path);
            var check = bll.ImportScoresEndterm(scores);
            if (check)
                MessageBox.Show("Import sucessed!");
            else
                MessageBox.Show("Import failed!");
        }

        private void Viewscorebttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewScoreboard viewscore = new ViewScoreboard();
            viewscore.ShowDialog();
            this.Close();
        }

        
    }
}
