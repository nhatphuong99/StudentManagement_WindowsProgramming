using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Student
    {
        public string studentid { get; set; }
        public string studentname { get; set; }
        public string classid { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string socialid { get; set; }
        public string pass { get; set; }

        public Student() { }
        public Student(string stuid, string soid, string name, string cid, DateTime _dob, string addr, string _sex)
        {
            studentid = stuid;
            socialid = soid;
            studentname = name;
            classid = cid;
            dob = _dob;
            address = addr;
            sex = _sex;

            string d = dob.Day.ToString("00");
            string m = dob.Month.ToString("00");
            int y = dob.Year;
            pass = $"{d}{m}{y}";
        }

        public Student(string stuid, string soid, string name, string _pass, string cid, DateTime _dob, string addr, string _sex)
        {
            studentid = stuid;
            socialid = soid;
            studentname = name;
            classid = cid;
            dob = _dob;
            address = addr;
            sex = _sex;
            pass = _pass;
        }
    }
}
