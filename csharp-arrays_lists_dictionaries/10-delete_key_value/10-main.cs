using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();
        Dictionary<string, string> newDict = new Dictionary<string, string>();

        // Add entries to the dictionary
        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        // Print the initial dictionary
        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("----------------");

        // Delete a key from the dictionary
        newDict = Dictionary.DeleteKeyValue(myDict, "track");

        // Print the updated dictionary
        foreach (KeyValuePair<string, string> entry in newDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);

        Console.WriteLine("-----");

        // Print the updated dictionary again to verify the deletion
        foreach (KeyValuePair<string, string> entry in myDict)
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
    }
}
