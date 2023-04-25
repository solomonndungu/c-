bool isEqual = 5 == 5; // true
bool notEqual = 5 != 1; // true

bool greaterThan = 5 > 2; // true
bool lessThan = 1 < 6; // true

bool greaterThanEqual = 5 >= 5; // true
bool lessThanEqual = 7 <= 7; // true

// AND OR
bool andAnd = 5 == 5 && 3 != 7; // true
bool orOr = 5 == 5 || 3 == 7; // true

if (5 == 1)
{
    Console.WriteLine("true");
}
else if (3 == 3)
{
    Console.WriteLine("Else if true");
}
else
{
    Console.WriteLine("Else true");
}

// If true, return first number on the other side of the ?
var inlineStatement = 3 > 2 ? 10 : 5;
var inlineStatementTwo = 4 > 2 ? 5 : 6;
var inlineStatementFalse = 2 == 1 ? 0 : 1;
