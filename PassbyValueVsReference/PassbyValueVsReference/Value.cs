using System;
// Value - outside function variable is NOT going to change
int num1 = 5;
int num2 = 10;

Console.WriteLine(num1 + " " + num2);
Square(num1, num2);
Console.WriteLine(num1 + "" + num2);


void Square(int a, int b)
{
    a = a * a;
    b = b * b;
}