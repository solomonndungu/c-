using System;
using System.Collections;

Hashtable numberNames = new Hashtable();
numberNames.Add(1, "One");
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

foreach(DictionaryEntry de in numberNames)
{
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
}

// Creating a Hashtable using collection-initializer syntax
var cities = new Hashtable()
{
    {"UK", "London, Manchester, Birmingham" },
    {"USA", "Chicago, New York, Washington" },
    {"India", "Mumbai, New Delhi, Dojoghty" }
};

foreach(DictionaryEntry de in cities)
{
    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
}