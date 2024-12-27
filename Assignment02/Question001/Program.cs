

namespace Question001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student = new Student[2];
            CreateArray(student);
            PrintInfo(student);
            ReverseArray(student);
        }
            public static void CreateArray(Student[] student)
            {
                for (int i = 0; i < student.Length; i++)
                {
                Console.WriteLine("Enter student" + i + "Details");
                        student[i] = new Student();
                    student[i].AcceptDetails();
                }
            }

            public static void PrintInfo(Student[] student)
            {
                for (int i = 0; i < student.Length; i++)
                {
                    Console.WriteLine(student[i].PrintDetails());
                }
            }

            public static void ReverseArray(Student[] student)
            {
                int j = 0;
                Student[] student2 = new Student[2];
                for (int i = student.Length - 1; i >= 0; i--)
                {
                    student2[j++] = student[i];
                }
            Console.WriteLine("Student Details in reverse order");

                for (int i = 0; i < student2.Length; i++)
                {
                    Console.WriteLine(student2[i].PrintDetails());
                }
            }
        
        public struct Student
        {
            private string _Name;
            private bool _Gender;
            private int _Age;
            private int _Std;
            private char _Div;
            private double _Marks;

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public bool gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }

            public int age
            {
                get { return _Age; }
                set { _Age = value; }
            }
            public int std
            {
                get { return _Std; }
                set { _Std = value; }
            }
            public char div
            {
                get { return _Div; }
                set { _Div = value; }
            }
            public double marks
            {
                get { return _Marks; }
                set { _Marks = value; }
            }

            public Student()
            {
                Name = "";
                gender = false;
                age = 0;
                std = 0;
                div = 'A';
                marks = 0;
            }

            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                _Name = name;
                _Gender = gender;
                _Age = age;
                _Std = std;
                _Div = div;
                _Marks = marks;
            }

            public void AcceptDetails()
            {
                Console.WriteLine("Enter the name:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the Gender:");
                gender = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter the Age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Standared");
                std = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Division:");
                div = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the Marks:");
                marks = Convert.ToDouble(Console.ReadLine());
            }

            public string PrintDetails()
            {
                return Name+" "+gender+" "+age+" "+std+" "+div+" "+marks;
            }
        }
    }
}
