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
    public partial class ViewScoreboard : Form
    {
        clsResize _form_resize;
        public ViewScoreboard()
        {
            InitializeComponent();
            ClassComboxLoad();
            SubjectComboxLoad();

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

        private void ViewScoreboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            TeacherMenu teacher = new TeacherMenu();
            teacher.ShowDialog();
        }

        private void Editbttn_Click(object sender, EventArgs e)
        {
            if (this.listscore.SelectedItems.Count > 0)
            {
                Edit edit = new Edit();
                Score sc = (Score)listscore.SelectedItems[0].Tag;
                edit.StuID.Text = edit.StuID.Text + sc.studentid;
                edit.SubID.Text = edit.SubID.Text + sc.subjectid;
                edit.ClassID.Text = edit.ClassID.Text + sc.classid;
                edit.Sem.Text = edit.Sem.Text + sc.semester;
                edit.Mid.Text = sc.midterm.ToString();
                edit.Fin.Text = sc.final.ToString();
                edit.Oth.Text = sc.other.ToString();
                edit.Total.Text = sc.total.ToString();
                edit.ShowDialog();
                ReloadList();
            }
            
        }

        private void Classcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectcb.Text != "")
            {
                var scrs = new BLL.BLL().ViewScoreboardsc(classcb.SelectedItem.ToString(), subjectcb.Text);
                ViewScoreList(scrs);
         
            }
            else
            {
                var scrs = new BLL.BLL().ViewScoreboardclass(classcb.SelectedItem.ToString());
                ViewScoreList(scrs);
            }
            classcb.Text = classcb.SelectedItem.ToString();
        }



        private void ViewScoreList(List<Score> scrs)
        {
            this.listscore.BeginUpdate();
            this.listscore.Clear();

            this.listscore.Columns.Add("MSSV", 100);
            this.listscore.Columns.Add("Mã lớp", 100);
            this.listscore.Columns.Add("Mã môn", 100);
            this.listscore.Columns.Add("Học kỳ", 100);
            this.listscore.Columns.Add("Điểm giữa kỳ", 150);
            this.listscore.Columns.Add("Điểm cuối kỳ", 150);
            this.listscore.Columns.Add("Điểm khác", 150);
            this.listscore.Columns.Add("Điểm tổng", 150);

            foreach (Score scr in scrs)
            {
                String[] sc = new String[8];
                sc[0] = scr.studentid;
                sc[1] = scr.classid;
                sc[2] = scr.subjectid;
                sc[3] = scr.semester;
                sc[4] = scr.midterm.ToString();
                sc[5] = scr.final.ToString();
                sc[6] = scr.other.ToString();
                sc[7] = scr.total.ToString();

                ListViewItem item = new ListViewItem(sc);
                item.Tag = scr;
                this.listscore.Items.Add(item);
            }
            this.listscore.View = View.Details;
            this.listscore.FullRowSelect = true;
            this.listscore.EndUpdate();
        }

        private void ClassComboxLoad()
        {
            this.classcb.BeginUpdate();
            var classids = new BLL.BLL().GetClassesIDFromDB();
            foreach (var cid in classids)
            {
                this.classcb.Items.Add(cid.classid);
            }
            this.classcb.EndUpdate();
        }

        public void ReloadList()
        {
            if (classcb.Text != "" && subjectcb.Text != "")
            {
                var scrs = new BLL.BLL().ViewScoreboardsc(classcb.Text, subjectcb.SelectedItem.ToString());
                ViewScoreList(scrs);
            }
            else if (classcb.Text == "")
            {
                var scrs = new BLL.BLL().ViewScoreboardsub(subjectcb.SelectedItem.ToString());
                ViewScoreList(scrs);
            }
            else if (subjectcb.Text == "")
            {
                var scrs = new BLL.BLL().ViewScoreboardclass(classcb.SelectedItem.ToString());
                ViewScoreList(scrs);
            }
        }

        private void SubjectComboxLoad()
        {
            this.subjectcb.BeginUpdate();
            var subids = new BLL.BLL().GetSubjectsIDFromDB();
            foreach (var subid in subids)
            {
                this.subjectcb.Items.Add(subid.subjectid);
            }
            this.subjectcb.EndUpdate();
        }

        private void Subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classcb.Text != "")
            {
                var scrs = new BLL.BLL().ViewScoreboardsc(classcb.Text, subjectcb.SelectedItem.ToString());
                ViewScoreList(scrs);

            }
            else
            {
                var scrs = new BLL.BLL().ViewScoreboardsub(subjectcb.SelectedItem.ToString());
                ViewScoreList(scrs);
            }
            subjectcb.Text = classcb.SelectedItem.ToString();
        }

        private void Addbttn_Click(object sender, EventArgs e)
        {
            AddScoreStudent add = new AddScoreStudent();
            add.ShowDialog();
            ReloadList();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (this.listscore.SelectedItems.Count > 0)
            {
                Score sc = (Score)listscore.SelectedItems[0].Tag;
                var dlt = new BLL.BLL().DeleteScore(sc);
                if (dlt)
                    MessageBox.Show("Delete successed");
                else MessageBox.Show("Delete failed");
                ReloadList();
            }
        }

    }
}
