using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KosovaPA.Task1.V3
{
    internal class Teacher
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public Subject Subject { get; private set; }
        public Department Department { get; private set; }
        public int Classroom { get; private set; }

        public Teacher(string name, string position, Subject subject, Department department, int classroom)
        {
            Name = name;
            Position = position;
            Subject = subject;
            Department = department;
            Classroom = classroom;
        }
    }
}
