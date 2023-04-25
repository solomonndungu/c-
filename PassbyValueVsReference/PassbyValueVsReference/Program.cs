// Value - The value is actually there.
int i = 2;

Person p1 = new Person();
Person p2 = new Person();

p1.Age = 5;
p2.Age = 10;

Console.WriteLine(p1);
Square(p1, p2);
Console.WriteLine(p1.Age + "" + p2.Age);

void Square(Person a, Person b)
{
    a.Age = a.Age * a.Age;
    b.Age = b.Age * b.Age;
    Console.WriteLine(a.Age + "" + b.Age);
}

// Reference - points to an address in memory where it is stored.
 class Person
 {
    public int Age { get; set; }
 }
