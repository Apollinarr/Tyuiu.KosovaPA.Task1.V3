using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KosovaPA.Task1.V3
{
    internal class Subject
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public bool IsExam { get; private set; }

        public Subject(int code, string name, int hours, bool isExam)
        {
            Code = code;
            Name = name;
            Hours = hours;
            IsExam = isExam;
        }
    }
}
