using System;
using Country;

namespace School
{
    public class Person: Citizen
    {
        public string name;

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

            // Age passes because it is inherited from Citizen project
            Console.WriteLine("Age is " + formOneStudent.Age());

            Console.WriteLine("stream is" + formOneStudent.streamm);

            Console.WriteLine("admission number is" + formOneStudent.admissionNumber());

        }
    }
}