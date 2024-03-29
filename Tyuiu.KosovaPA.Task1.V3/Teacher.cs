namespace Tyuiu.KosovaPA.Task1.V3
{
    public class Teacher
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public Subject? Subject { get; private set; }
        public Department? Department { get; private set; }
        public int Classroom { get; private set; }

        public Teacher(string name, string position, Subject? subject, Department? department, int classroom)
        {
            Name = name;
            Position = position;
            Subject = subject;
            Department = department;
            Classroom = classroom;
        }

        public Teacher(string name, string position, int classroom)
        {
            Name = name;
            Position = position;
            Subject = null;
            Department = null;
            Classroom = classroom;
        }

        public void AppointDepartment(Department department) => Department = department;

        public void AppointSubject(Subject subject) => Subject = subject;

        public override string ToString()
        {
            if (Subject is null)
            {
                if (Department is null)
                {
                    return Name + " " + Position + " " + "-" + " " + "-" + " " + Classroom.ToString();
                }
                else
                {
                    return Name + " " + Position + " " + "-" + " " + Department.Name + " " + Classroom.ToString();
                }
            }
            else
            {
                if (Department is null)
                {
                    return Name + " " + Position + " " + Subject.Name + " " + "-" + " " + Classroom.ToString();
                }
                else
                {
                    return Name + " " + Position + " " + Subject.Name + " " + Department.Name + " " + Classroom.ToString();
                }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Teacher && Name == ((Teacher)obj).Name && Position == ((Teacher)obj).Position
                && Subject == ((Teacher)obj).Subject && Department == ((Teacher)obj).Department
                && Classroom == ((Teacher)obj).Classroom;
        }
    }
}
