// List -can be resized dynamically unlike arrays.
// List<T> class is not sorted by default and elements are accessed by zero-based index.
// List can store duplicate values
// List holds a particular data type.

class Class1
{
    public static void Main()
    {
        List<string> languages = new List<string>() { "Python", "Java", "C" };

        // Insert data at a particular index
        languages.Insert(2, "JavaScript");

        // Add normally without specifying the index
        languages.Add("C#");

        // Display data on index 2
        Console.WriteLine(languages[2]);

        // Loop through list to display values
        for (int i = 0; i < languages.Count; i++)
        {
            Console.WriteLine(languages[i]);

        }

        // Remove value on particular index
        languages.RemoveAt(0);

        // Remove specific value
        languages.Remove("C");

        // Show existing value at index 0
        Console.WriteLine(languages[0]);
    }
}