using System;
using System.Collections.Generic;
using System.Text;

namespace baitap410
{
    public class SubjectStudent
    {
        public int id { get; set; }
        public string name { get; set; }
        public int semes { get; set; }
        public string teacher { get; set; }
        public List<Student> students { get; set; } = new List<Student>();
    }
}