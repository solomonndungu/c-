using System;
using System.Collections;

Hashtable numberNames = new Hashtable();
numberNames.Add(1, "One");
numberNames.Add(2, "Two");

foreach(DictionaryEntry de in numberNames)
{
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
}

// Creating a Hashtable using collection-initializer syntax
var cities = new Hashtable()
{
    {"UK", "London, Manchester, Birmingham" },
    {"USA", "Chicago, New York, Washington" }
};

foreach(DictionaryEntry de in cities)
{
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
}