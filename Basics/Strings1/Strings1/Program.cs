using System.Text;
// Strings - an object whose value is text.
// Reference type

// double
string testString = "test";

// single
char[] testLowLevel = new[] { 't', 'e', 's', 't' };

String testStringStatic = "testStatic";

string message1;

string message2 = null;

// Literal vs Verbatim
string filePath = "c:\\ProgramFiles";

string filePathVerbatim = @"c\ProgramFiles";

// String Interpolation
string firstName = "Teddy";
string lastName = "Smith";

Console.WriteLine($"My name is {firstName} {lastName}");

// Composite Formatting
Console.WriteLine("My name is {0} {1}", firstName, lastName);

// String Builder
var sb = new StringBuilder();
var testStringBuilder = sb.Append(firstName);
Console.WriteLine(lastName);

var singleLine = """
    This is a "raw string literal".
    It can contain characters like \, ' and ".
    """;

Console.WriteLine(singleLine);

string[] @for =
{
    "John",
    "James",
    "Joan",
    "Jamie"
};

for(int ctr = 0; ctr<@for.Length; ctr++)
{
    Console.WriteLine($"Here is your gift,{@for[ctr]}");
}

string name1 = "Jules";
string name2 = "Joel";

Console.WriteLine("My name is {0} {1}", name1, name2);