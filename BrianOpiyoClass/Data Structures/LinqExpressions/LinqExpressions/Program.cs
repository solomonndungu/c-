using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal;
using Newtonsoft.Json;

namespace Linq_Assignment
{
    internal class Program
    {


        static int GenerateRandomScore()
        {
            Random random = new Random();
            return random.Next(50, 101); // Generates a random score between 50 and 100 (inclusive)

        }

        static IList<Student> studentList = new List<Student>();

        static void AddStudents()
        {
            for (int i = 1; i <= 20; i++)
            {
                Student student = new Student()
                {
                    No = i,
                    Name = $"Student {i}",
                    Gender = i % 2 == 0 ? "Male" : "Female"
                };

                studentList.Add(student);
            }
        }


        static IList<Unit> units = new List<Unit>()
        {
            new Unit() { Nmbr = 1, Name = "Mathematics", Tutor = "John Smith" },
            new Unit() { Nmbr = 2, Name = "Science", Tutor = "Emma Johnson" },
            new Unit() { Nmbr = 3, Name = "English", Tutor = "David Thompson" },
            new Unit() { Nmbr = 4, Name = "History", Tutor = "Sarah Wilson" },
            new Unit() { Nmbr = 5, Name = "Programming", Tutor = "Michael Brown" }
        };




        static IList<Mark> marks = new List<Mark>();

        static void AddMarks()
        {
            foreach (var student in studentList)
            {
                foreach (var unit in units)
                {
                    Mark mark = new Mark()
                    {
                        No = marks.Count + 1,
                        Unit_No = unit.Nmbr,
                        Student_No = student.No,
                        Score = GenerateRandomScore()
                    };

                    marks.Add(mark);
                }
            }
        }


        public static void Main(string[] args)
        {
            AddStudents();

            AddMarks();

            //Query

            var studentQuery = (from student in studentList.Take(16)
                                from unit in units
                                join mark in marks on new { Student_No = student.No, Unit_No = unit.Nmbr } equals new { mark.Student_No, mark.Unit_No } into markGroup
                                from mark in markGroup.DefaultIfEmpty()
                                select new
                                {
                                    StudentName = student.Name,
                                    UnitName = unit.Name,
                                    Score = mark != null ? mark.Score : 0,
                                    UnitTutor = unit.Tutor
                                });//.Skip(5);

            //Expression

            var studentQuery2 = studentList.Take(2)
                .SelectMany(student => units
                .GroupJoin(marks,
                unit => new { Student_No = student.No, Unit_No = unit.Nmbr },
                mark => new { mark.Student_No, mark.Unit_No },
                (unit, markGroup) => new
                {
                    StudentName = student.Name,
                    UnitName = unit.Name,
                    Score = markGroup.DefaultIfEmpty().Select(mark => mark?.Score ?? 0).FirstOrDefault(),
                    UnitTutor = unit.Tutor
                })
                );


            foreach (var result in studentQuery)
            {
                //Console.WriteLine($"Student Name: {result.StudentName}, Unit Name: {result.UnitName}, Score: {result.Score}, Unit Tutor: {result.UnitTutor}");
                string json = JsonConvert.SerializeObject(result);
                Console.WriteLine(json);
            }

        }
    }
}