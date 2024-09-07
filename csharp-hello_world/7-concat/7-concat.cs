using System;
class Program
{
    static void Main(string[] args)
    {
        string str1 = "Welcome to";
        string str2 = " Holberton School!";
        Console.WriteLine(str1 + str2);   // Output: "Welcome to Holberton School!"
        str2 = " Mission Street!";
        Console.WriteLine(str1 + str2);   // Output: "Welcome to Mission Street!"
    }
}