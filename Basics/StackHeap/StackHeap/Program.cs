//Stack is for value type and a Heap is for reference types
using StackHeap1;

int testValue = 4;
byte lowLevelValue = 3;
bool boolValue = false; // Stored in stack
string stringValue = "string"; // Reference type

Console.WriteLine(stringValue);

StackHeapExample stackHeap = new StackHeapExample();

stackHeap.AddFive(1);