﻿using System;
using Country;

namespace School
{

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

            // Demonstrating method overloading
            Console.WriteLine($"Results for programming are: {student.GradeA(67, 83, 72)}");
            Console.WriteLine($"Results for soft skills are: {student.GradeA(87, 85)}");
            Console.WriteLine($"Results for Game Theory is: {student.GradeA(69)}");

            // Demonstrating method overriding
            Console.WriteLine($"Compulsory subjects for a form one student is {formOneStudent.compulsorySciences()}");
            Console.WriteLine($"Compulsory subjects for any student is {student.compulsorySciences()}");

        }
    }
}

/*The code block for the get accessor is executed when the property is read; the code block
 * for the set accessor is executed when the property is assigned a value. A property without 
 * a set accessor is considered read-only. A property without a get accessor is considered write-only. 
 * A property that has both accessors is read-write.
 */



// overriding multiple implementations
// overloading different


// Reference a solution scope
// Research on how to reference assembly and libraries from external sources
// Overloading and overriding

// Differentiate with code: Method overloading, Method overriding using
// a totally different method (not age)

// Create another assembly and add classes to it. Make assembly Country reference
// the new assembly. Try to pass down inherited method and properties down to
// form 1 student.

// Accessors and mutators. Explain them and also show how to use it.
