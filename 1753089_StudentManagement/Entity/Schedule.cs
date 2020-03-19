using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Schedule
    {
        public string subjectid { get; set; }
        public string classid { get; set; }
        public string semester { get; set; }
        public string year { get; set; }
        public string room { get; set; }
        public char publictosee { get; set; }

        public Schedule() { }
        public Schedule(string cid, string subid, string sem, string y, string r, char pub)
        {
            subjectid = subid;
            classid = cid;
            semester = sem;
            year = y;
            room = r;
            publictosee = pub;
        }

        public Schedule(string cid, string subid, string sem, string y, string r)
        {
            subjectid = subid;
            classid = cid;
            semester = sem;
            year = y;
            room = r;
            publictosee = '0';
        }

    }
}
