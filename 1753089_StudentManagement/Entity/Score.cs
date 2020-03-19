using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Score
    {
        public string studentid { get; set; }
        public string classid { get; set; }
        public string subjectid { get; set; }
        public string semester { get; set; }
        public float midterm { get; set; }
        public float final { get; set; }
        public float other { get; set; }
        public float total { get; set; }

        public Score() { }
        public Score(string sid, string cid, string subid, string sem)
        {
            studentid = sid;
            classid = cid;
            subjectid = subid;
            semester = sem;
            midterm = 0;
            final = 0;
            other = 0;
            total = 0;
        }

        public Score(string sid, string cid, string subid, string sem, float mid, float fin, float oth, float ttl)
        {
            studentid = sid;
            classid = cid;
            subjectid = subid;
            semester = sem;
            midterm = mid;
            final = fin;
            other = oth;
            total = ttl;
        }
    }
}
