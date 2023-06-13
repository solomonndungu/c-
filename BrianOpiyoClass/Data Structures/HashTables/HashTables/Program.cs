// Hashtable is a non-generic collection that stores key-value pairs based on the hashcode of each value key.
// Dictionary - generic collection that stores key value pairs in no particular order.
// Dictionary comes under System.Collections.Generic namespace. The keys must be unique and cannot be null.
// Dictionary values can be null or duplicate.
// Usecase for hashtable: accessing of data.
using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Hashtable
        Hashtable hashtable = new Hashtable();

        // Adding key-value pairs to the table
        hashtable.Add(1, "value1");

        hashtable.Add(2, "value2");

        // Hashtable can have an empty value but not an empty key
        hashtable.Add(3, "");

        // Iterating over the hashtable
        foreach(DictionaryEntry entry in hashtable)
        {
            Console.WriteLine("Key: {0} value {1}", entry.Key, entry.Value);
        }

        // Checking the count of key-value pairs
        Console.WriteLine(hashtable.Count);
    }
}

// Array limitation: has a specific data type
// Dictionary/Hashtable is used for accessing of data.