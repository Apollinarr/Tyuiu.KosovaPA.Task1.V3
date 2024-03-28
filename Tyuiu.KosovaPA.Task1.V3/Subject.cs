using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KosovaPA.Task1.V3
{
    public class Subject
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

        public override string ToString()
        {
            if (IsExam)
            {
                return Code.ToString() + " " + Name + " " + Hours.ToString() + " " + "Экзамен";
            }
            else
            {
                return Code.ToString() + " " + Name + " " + Hours.ToString() + " " + "Зачёт";
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Subject && Code == ((Subject)obj).Code && Name == ((Subject)obj).Name && Hours == ((Subject)obj).Hours && IsExam == ((Subject)obj).IsExam;
        }
    }
}
