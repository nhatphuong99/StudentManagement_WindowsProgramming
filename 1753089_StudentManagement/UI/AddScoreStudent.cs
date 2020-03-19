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
    public partial class AddScoreStudent : Form
    {
        clsResize _form_resize;
        public AddScoreStudent()
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

        private void AddScoreStudent_Load(object sender, EventArgs e)
        {

        }

        private void Addokbttn_Click(object sender, EventArgs e)
        {
            string sem = "";
            if (springbttn.Checked)
                sem = springbttn.Text;
            else if (sumbttn.Checked)
                sem = sumbttn.Text;
            else if (fallbtttn.Checked)
                sem = fallbtttn.Text;

            if (idtb.Text == "" || sem == "" || subtb.Text == "" || classtb.Text == "")
            {
                MessageBox.Show("Add score failed");

            }
            else
            {


                var sc = new Score(idtb.Text, classtb.Text, subtb.Text, sem, float.Parse(midtermtb.Text), float.Parse(finaltb.Text), float.Parse(othtb.Text), float.Parse(totaltb.Text));

                var add = new BLL.BLL().AddNewScore(sc);
                if (add)
                {
                    MessageBox.Show("Add score successed");
                    this.Close();
                }
                else
                    MessageBox.Show("Add score failed");
            }
        }

        private void Adjcancelbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
