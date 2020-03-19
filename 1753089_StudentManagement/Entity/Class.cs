using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Class
    {
        public string classid { get; set; }
        public string classname { get; set; }

        public Class() { }
        public Class(string id, string name)
        {
            classid = id;
            classname = name;
        }
    }
}
