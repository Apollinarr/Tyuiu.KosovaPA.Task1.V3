namespace Tyuiu.KosovaPA.Task1.V3
{
    public class Department
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public Teacher? HeadTeacher { get; private set; }

        public Department(int code, string name, Teacher? teacher)
        {
            Code = code;
            Name = name;
            HeadTeacher = teacher;
        }

        public Department(int code, string name) 
        {
            Code = code;
            Name = name;
            HeadTeacher = null;
        }

        public void AppointHeadTeacher(Teacher teacher) => HeadTeacher = teacher;

        public override string ToString()
        {
            if (HeadTeacher == null)
            {
                return Code.ToString() + " " + Name.ToString() + " " + "-";
            }
            else
            {
                return Code.ToString() + " " + Name.ToString() + " " + HeadTeacher.Name.ToString();
            }
        }

        public bool CompareTo(Department other) => Code == other.Code && Name == other.Name && HeadTeacher == other.HeadTeacher;
    }
}
