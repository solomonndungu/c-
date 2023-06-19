// https://www.codecademy.com/learn/cspath-asymptotic-notation/modules/cspath-asymptotic-notation/cheatsheet#
// Asymptotic notation - time and space complexity a program takes to run and give an output.
// It can be a program with a for loop, foreach...

int num1 = 2;

int num2 = 5;

int num3 = num1 * num2;

Console.WriteLine(num3);

// When defining complexity, use variable names rather than values
// e.g O(N(X))


public class Notations
{
    public static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>(input.Length);
        foreach (char c in input)
        {
            stack.Push(c);
        }



        string reversed = "";
        while (!stack.IsEmpty())
        {
            reversed += stack.Pop();
        }



        return reversed;
    }



    public static void Main()
    {
        string input = "Hello, World!";
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }
}

public class Squareee
{
    private int side;
    public Square(int n)
    {
        side = n;
    }


    public int Square(int n) => side = n;

    public override int GetArea()
    {
        return side * side;
    }
}


// Read about abstract classes

// Convert.ToInt32

// Read lists (me, Njambi, Edwin), hashset, hashtables