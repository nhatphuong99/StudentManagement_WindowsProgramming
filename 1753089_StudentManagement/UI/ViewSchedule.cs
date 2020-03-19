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
    public partial class ViewSchedule : Form
    {
        clsResize _form_resize;
        public ViewSchedule()
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

        private void ViewSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            TeacherMenu teacher = new TeacherMenu();
            teacher.ShowDialog();
        }


        private void Classcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectcb.Text != "")
            {
                var schs = new BLL.BLL().ViewSchedulesc(classcb.SelectedItem.ToString(), subjectcb.Text);
                ViewScoreList(schs);

            }
            else
            {
                var schs = new BLL.BLL().ViewScheduleclass(classcb.SelectedItem.ToString());
                ViewScoreList(schs);
            }
            classcb.Text = classcb.SelectedItem.ToString();
        }



        private void ViewScoreList(List<Schedule> schs)
        {
            this.listschedule.BeginUpdate();
            this.listschedule.Clear();
            this.listschedule.FullRowSelect = true;
            this.listschedule.Columns.Add("Mã lớp", 100);
            this.listschedule.Columns.Add("Mã môn", 100);
            this.listschedule.Columns.Add("Học kỳ", 100);
            this.listschedule.Columns.Add("Năm", 100);
            this.listschedule.Columns.Add("Phòng", 100);
            this.listschedule.Columns.Add("Công khai điểm", 150);

            foreach (Schedule sch in schs)
            {
                String[] sc = new String[6];
                sc[0] = sch.classid;
                sc[1] = sch.subjectid;
                sc[2] = sch.semester;
                sc[3] = sch.year;
                sc[4] = sch.room;
                sc[5] = sch.publictosee.ToString();

                ListViewItem item = new ListViewItem(sc);
                this.listschedule.Items.Add(item);
            }
            this.listschedule.View = View.Details;
            this.listschedule.EndUpdate();
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
                var schs = new BLL.BLL().ViewSchedulesc(classcb.Text, subjectcb.SelectedItem.ToString());
                ViewScoreList(schs);

            }
            else 
            {
                var schs = new BLL.BLL().ViewSchedulesub(subjectcb.SelectedItem.ToString());
                ViewScoreList(schs);
            }
            subjectcb.Text = classcb.SelectedItem.ToString();
        }
    }
}
