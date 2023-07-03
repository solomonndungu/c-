using System;
using System.Collections.Generic;
using System.Linq;
namespace linq
{
    public class Students
    {
        internal int number;
        internal string name;
        internal char gender;
        public Students(int number, string name, char gender)
        {
            this.number = number;
            this.name = name;
            this.gender = gender;
        }

    }
    public class Units
    {
        internal int number;
        internal string name;
        internal string tutor;
        public Units(int num, string jina, string tutor)
        {
            this.number = num;
            this.name = jina;
            this.tutor = tutor;
        }


    }
    internal class Marks
    {
        private int number;
        internal int unit_Number;
        internal int student_Number;
        internal int Score;
        public Marks(int number, int unit_Number, int student_Number, int score)
        {
            this.number = number;
            this.unit_Number = unit_Number;
            this.student_Number = student_Number;
            this.Score = score;
        }

    }
    public class Program
    {


        public static void Main(string[] args)
        {
            List<Students> students = new List<Students>()
        {
            new Students (101 , "Solo ", 'M'),
            new Students(102, "Njambi",'F'),
            new Students(103, "Gladys", 'M'),
            new Students(104, "Kasengi", 'F'),
            new Students(105, "Gladwell", 'M'),
            new Students(106, "Shem", 'F'),
            new Students(107, "Karen", 'M'),
            new Students(108, "Edwin", 'F'),
            new Students(109, "Scola", 'M'),
            new Students(110, "Ken", 'F'),
            new Students(111, "Brian", 'M'),
            new Students(112, "Steve", 'F'),
            new Students(113, "Andrew", 'M'),
            new Students(114, "Julie", 'F'),
            new Students(115, "Ryan", 'M'),
            new Students(116, "Mercy", 'F'),
            new Students(117, "James", 'M'),
            new Students(118, "Sofia", 'F'),
            new Students(119, "Benjamin", 'M'),
            new Students(120, "Ella", 'F')



        };

            List<Units> units = new List<Units>()
        {
            new Units(1, "Net","Steve"),
            new Units(2,"Intro c#","Steve"),
            new Units(3, "OOP","Brian"),
            new Units(4,"DataTypes","Brian"),
            new Units(5, "Linq","Steve"),



        };
            List<Marks> marks = new List<Marks>()
        {
            new Marks(1,1,107,20),
            new Marks(2,2,108,40),
            new Marks(3,3,109,20),
            new Marks(4,4,110,40),
            new Marks(5,5,111,20),




        };
            var studentQuery = (from st in students.Take(9)
                                join mks in marks
                                    on st.number equals mks.student_Number
                                join un in units
                                    on mks.unit_Number equals un.number
                                select new
                                {
                                    StudentName = st.name,
                                    StudentNumber = st.number,
                                    UnitName = un.name,
                                    UnitScore = mks.Score,
                                    UnitTutor = un.tutor,
                                    UnitNumber = un.number,
                                }); // Use Skip or Take

            /*var studentquery = (from student in students
                                join mark in marks on student.number equals mark.student_Number
                                join unit in units on mark.unit_Number equals unit.number
                                select new
                                {

                                    student_name = student.name,
                                    student_Number = student.number,
                                    unit_number = mark.unit_Number,
                                    unit_score = mark.unit_Number,
                                    unit_name = unit.name,
                                    unit_tutor = unit.tutor,

                                })
                                .Skip(4)
                              .Take(16);*/
            foreach (var result in studentQuery)
            {
                Console.WriteLine($"Student Name: {result.StudentName}");
                Console.WriteLine($"Student Number: {result.StudentNumber}");
                Console.WriteLine($"Unit Number: {result.UnitNumber}");
                Console.WriteLine($"Unit Score: {result.UnitScore}");
                Console.WriteLine($"Unit Name: {result.UnitName}");
                Console.WriteLine($"Unit Tutor: {result.UnitTutor}");
                Console.WriteLine();
            }



        }
    }
}