using System;
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
            new Students(102, "Njambi",'F')
        };
            List<Units> units = new List<Units>()
        {
            new Units(1, "Net","Steve"),
            new Units(2,"Intro c#","Steve")
        };
            List<Marks> marks = new List<Marks>()
        {
            new Marks(1,1,2,20),
            new Marks(1,2,1,40)
        };
            var studentquery = from student in students
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
                                   //   studentBetween5And20 = student_Number.Skip(4).Take(16),
                               };


        }
    }
}
//utilize skip and take query options and add where clause to filter