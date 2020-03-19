using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Teacher
    {
        public string teacherid { get; set; }
        public string teachername { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string socialid { get; set; }
        public string pass { get; set; }

        public Teacher() { }
        public Teacher(string id, string sid, string name, string _pass, DateTime _dob, string addr, string _sex)
        {
            teacherid = id;
            teachername = name;
            dob = _dob;
            address = addr;
            sex = _sex;
            socialid = sid;
            pass = _pass;
        }
    }
}
