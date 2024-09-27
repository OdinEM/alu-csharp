using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        string key;
        string value;

        key = "school";
        value = "Holberton";

        // Add or update the key-value pair in the dictionary
        Dictionary.AddKeyValue(myDict, key, value);

        // Print the dictionary
        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("------------------");

        key = "city";
        value = "San Francisco";

        // Add or update the key-value pair in the dictionary
        Dictionary.AddKeyValue(myDict, key, value);

        // Print the dictionary
        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
