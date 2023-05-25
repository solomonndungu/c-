// Accessors, mutators: resear

namespace School
{
    public class Person
    {
        public string name;
        private DateTime dateOfBirth;

        public int Age()
        {
            // return Age
            DateTime now = DateTime.Now;
            return (now - dateOfBirth).Days / 365;
        }
    }

    public class Teacher : Person
    {
        public string tscNumber;

    }

    public class Student : Person
    {
        protected int admNumber;
    }

    public class FormOneStudent : Student
    {
        public readonly string streamm = "1Green";

        public int admissionNumber()

        {
            return admNumber;
        }
    }

    public class Masomo
    {
        static void Main(string[] args)
        {
            FormOneStudent formOneStudent = new FormOneStudent();

            Student student = new Student();

            Teacher teacher = new Teacher();

            Person person = new Person();

            Console.WriteLine("Age is " + formOneStudent.Age());

            Console.WriteLine("stream is" + formOneStudent.streamm);

            Console.WriteLine("admission number is" + formOneStudent.admNumber);

        }
    }
}