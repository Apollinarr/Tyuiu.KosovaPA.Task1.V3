using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KosovaPA.Task1.V3
{
    internal class Department
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public Teacher HeadTeacher { get; private set; }

        public Department(int code, string name, Teacher teacher)
        {
            Code = code;
            Name = name;
            HeadTeacher = teacher;
        }
    }
}
