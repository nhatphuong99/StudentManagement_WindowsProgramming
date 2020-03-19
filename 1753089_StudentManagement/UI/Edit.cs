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
    public partial class Edit : Form
    {
        clsResize _form_resize;
        public Edit()
        {
            InitializeComponent();

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

        public Label StuID
        {
            get { return idlb; }
            set { idlb = value; }

        }

        public Label SubID
        {
            get { return subjectidlb; }
            set { subjectidlb = value; }

        }
        public Label ClassID
        {
            get { return classlb; }
            set { classlb = value; }

        }
        public Label Sem
        {
            get { return semlb; }
            set { semlb = value; }

        }
        public TextBox Mid
        {
            get { return midtermtb; }
            set { midtermtb = value; }

        }
        public TextBox Fin
        {
            get { return finaltb; }
            set { finaltb = value; }

        }
        public TextBox Oth
        {
            get { return othtb; }
            set { othtb = value; }

        }
        public TextBox Total
        {
            get { return totaltb; }
            set { totaltb = value; }

        }

        private void Adjcancelbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adjokbttn_Click(object sender, EventArgs e)
        {
            var stu = idlb.Text.Split(':');
            string stuid = stu[1];
            var cls = classlb.Text.Split(':');
            string cid = cls[1];
            var subj = subjectidlb.Text.Split(':');
            string subid = subj[1];
            var semes = semlb.Text.Split(':');
            string sem = semes[1];
            var upd = new BLL.BLL().UpdateStudentScore(float.Parse(midtermtb.Text), float.Parse(finaltb.Text), float.Parse(othtb.Text), float.Parse(totaltb.Text), stuid, subid, cid, sem);
            if (upd)
            {
                MessageBox.Show("Change successed");
                this.Close();
            }
            else
                MessageBox.Show("Change failed");
        }
    }
}
