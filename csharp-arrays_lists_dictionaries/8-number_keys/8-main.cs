using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");

        // Call the NumberOfKeys method and print the result
        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
    }
}
