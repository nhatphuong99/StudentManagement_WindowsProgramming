using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace UI
{

    public partial class StudentViewScore : Form
    {
        clsResize _form_resize;
        public string id;
        public StudentViewScore(string sid)
        {
            InitializeComponent();
            id = sid;
            ComboxLoad(sid);
            ListLoad(sid);

            _form_resize = new clsResize(this);
            this.Load += _Load;
            this.Resize += _Resize;
        }

        private void _Load(object sender, EventArgs e)
        {
            _form_resize._get_initial_size();
        }

        private void _Resize(object sender, EventArgs e)
        {
            _form_resize._resize();
        }



        private void ComboxLoad(string sid)
        {
            this.subjectcb.BeginUpdate();
            var subjectids = new BLL.BLL().GetSubjectIDofStudentFromDB(sid);
            foreach (var subid in subjectids)
            {
                this.subjectcb.Items.Add(subid.subjectid);
            }
            this.subjectcb.EndUpdate();
        }

        private void ListLoad(string sid)
        {
            var scrs = new BLL.BLL().GetScoresStudent(sid);
            var stu = new BLL.BLL().GetStudent(sid);
            ViewList(scrs, stu);
        }

        private void ViewList(List<Score> scrs, Student stu)
        {
            this.liststudentscore.BeginUpdate();
            this.liststudentscore.Clear();

            this.liststudentscore.Columns.Add("MSSV", 100);
            this.liststudentscore.Columns.Add("Họ tên", 250);
            this.liststudentscore.Columns.Add("Mã môn", 100);
            this.liststudentscore.Columns.Add("Học kỳ", 100);
            this.liststudentscore.Columns.Add("Điểm giữa kỳ", 150);
            this.liststudentscore.Columns.Add("Điểm cuối kỳ", 150);
            this.liststudentscore.Columns.Add("Điểm khác", 150);
            this.liststudentscore.Columns.Add("Điểm tổng", 150);

            foreach (Score scr in scrs)
            {
                String[] sc = new String[8];
                sc[0] = scr.studentid;
                sc[1] = stu.studentname;
                sc[2] = scr.subjectid;
                sc[3] = scr.semester;
                sc[4] = scr.midterm.ToString();
                sc[5] = scr.final.ToString();
                sc[6] = scr.other.ToString();
                sc[7] = scr.total.ToString();

                ListViewItem item = new ListViewItem(sc);
                this.liststudentscore.Items.Add(item);
            }
            this.liststudentscore.View = View.Details;
            this.liststudentscore.EndUpdate(); ;
        }



        private void StudentViewScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            StudentMenu student = new StudentMenu();
            student.IDLabel.Text = student.IDLabel.Text + id;
            student.ShowDialog();
        }

        private void Subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var scrs = new BLL.BLL().GetScoresStudent(id);
            var stu = new BLL.BLL().GetStudent(id);
            var scr = new List<Score>();
            foreach (var sc in scrs)
                if (sc.subjectid == subjectcb.SelectedItem.ToString())
                    scr.Add(sc);
            ViewList(scr, stu);
            subjectcb.Text = subjectcb.SelectedItem.ToString();
        }


    }

    
}
