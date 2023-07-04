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
        internal int age;
        public Students(int number, string name, char gender, int age)
        {
            this.number = number;
            this.name = name;
            this.gender = gender;
            this.age = age;
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
            new Students (101 , "Solo", 'M', 23),
            new Students(102, "Njambi",'F', 22),
            new Students(103, "Gladys", 'M', 20),
            new Students(104, "Kasengi", 'F', 19),
            new Students(105, "Gladwell", 'M', 16),
            new Students(106, "Shem", 'F', 69),
            new Students(107, "Karen", 'M', 22),
            new Students(108, "Edwin", 'F', 25),
            new Students(109, "Scola", 'M', 17),
            new Students(110, "Ken", 'F', 24),
            new Students(111, "YoBrah", 'M', 27),
            new Students(112, "VoSte", 'F', 26),
            new Students(113, "Andrew", 'M', 21),
            new Students(114, "Julie", 'F', 20),
            new Students(115, "Ryan", 'M', 24),
            new Students(116, "Mercy", 'F', 22),
            new Students(117, "James", 'M', 20),
            new Students(118, "Sofia", 'F', 28),
            new Students(119, "Benjamin", 'M', 29),
            new Students(120, "Ella", 'F', 34)



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
            /*  var studentQuery = (from st in students.Take(9)
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
            */
            var studentquery = (from student in students
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
                              .Take(16);
            foreach (var result in studentquery)
            {
                Console.WriteLine($"Student Name: {result.student_name}");
                Console.WriteLine($"Student Number: {result.student_Number}");
                Console.WriteLine($"Unit Number: {result.unit_number}");
                Console.WriteLine($"Unit Score: {result.unit_score}");
                Console.WriteLine($"Unit Name: {result.unit_name}");
                Console.WriteLine($"Unit Tutor: {result.unit_tutor}");
                Console.WriteLine();
            }



            // LINQ Query Method to return students aged between 20 and 25, excluding students aged 22
            var studentage = students.Where(s => s.age > 20 && s.age < 25 && s.age != 22).ToList<Students>();

            Console.WriteLine("Students aged between 20 and 25,excluding 22:");
            //Print the result of the LINQ Method
            foreach (Students std in studentage)
            {
                Console.WriteLine(std.name);
            }

        }
    }
}