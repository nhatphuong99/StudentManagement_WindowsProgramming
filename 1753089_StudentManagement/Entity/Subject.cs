using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Subject
    {
        public string subjectid { get; set; }
        public string subjectname { get; set; }

        public Subject() { }
        public Subject(string id, string name)
        {
            subjectid = id;
            subjectname = name;
        }
    }
}
