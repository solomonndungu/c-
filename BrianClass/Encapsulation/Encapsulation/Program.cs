// Whenever an instance of a class or struct is created, its constructor is called.

/* A constructor is a method whose name is the same as the name of its type. Its
 method signature includes only an optional access modifier, the method name and its
 parameter list.*/

public class Person
{
    string last;
    string first;

    // Constructor
    public Person(string lastName, string firstName)
    {
        last = lastName;
        first = firstName;
    }
}

/* Encapsulation: a class or struct can specify how accessible each of its members is
 to code outside of the class or struct.*/

// public has no restrictions on access of its members
public class BaseClass
{
    /* protected of a base class is accessible in a derived class only if the access
     occurs through the derived class type */
    protected int x = 123;

    // Internal member is accessible only within files in the same assembly
    internal int ziroo = 0;

    /* protected internal is accessible from any type within its containing assembly.
     It's also accessible in a derived class located in another assembly only if the
     access occurs through a variable of the derived class type. */
    protected internal int myValue = 43;

    // Private members are accessible only within the body of the class in which they are declared
    private int i;

    // Private protected member is accessible by types derived from the containing class,
    // but only within its containing assembly
    private protected int myValue2 = 44;
}

public class BaseClass1
{
    public static void Main()
    {
        var p = new PointTest();

        // testing the public variable
        p.xxx = 10;
        Console.WriteLine($"x = {p.xxx}");

        // Accesses the private variable
        p.viewyy();

        p.xy;
    }
}

public class PointTest
{
    public int xxx;
    private int yy = 6;

    // View value of yy to be accessed by another class
    public int viewyy()
    {
        // Return immutable value
        return yy;
    }

    protected int xy = 123;

    protected internal int myValue1 = 0;
}

 //demonstrating a protected class
public class BaseClass1 : PointTest
{
    static void main()
    {
        var pointTest = new PointTest();
        var baseClass1 = new BaseClass1();

        // Class is derived from PointTest, so it will work
        baseClass1.xy = 10;

        Console.WriteLine($"{baseClass1.xy}");

        /* Demonstrating protected internal class
        var derivedObject = new BaseClass1();
        derivedObject.myValue1 = 10;

        Console.WriteLine($"{derivedObject.myValue1}");
        */
    }
}

// Accessors, mutators: resear

namespace School
{
    public class Person
    {
        public string name;
        private DateTime dateOfBirth;

        public int Age() {
           // return Age
            };
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
        private readonly string streamm = "1Green";
    }

    public class Masomo
    {
        static void Main(string[] args)
        {
            FormOneStudent formOneStudent = new FormOneStudent();

            Student student = new Student();

            Teacher teacher = new Teacher();

            Person person = new Person();


        }
    }
}