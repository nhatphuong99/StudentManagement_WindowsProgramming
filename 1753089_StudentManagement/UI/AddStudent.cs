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
    public partial class AddStudent : Form
    {
        clsResize _form_resize;
        public AddStudent()
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
        


        private void addokbt_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (maleButton.Checked)
                gender = maleButton.Text;
            else if (femaleButton.Checked)
                gender = femaleButton.Text;

            if (idlb.Text == "" || gender == "")
            {
                MessageBox.Show("Add student failed");
                
            }
            else
            {
                
                

                var date = dobtb.Text.Split('/');
                var _dob = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));


                var stu = new Student(idtb.Text, socialidtb.Text, nametb.Text, classtb.Text, _dob, addrtb.Text, gender);

                var add = new BLL.BLL().AddNewStudent(stu);
                if (add)
                {
                    MessageBox.Show("Add student successed");
                    this.Close();
                }
                else
                    MessageBox.Show("Add student failed");
            }

            
            
        }

        private void addcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            TeacherMenu teacher = new TeacherMenu();
            teacher.ShowDialog();
        }
    }
}
