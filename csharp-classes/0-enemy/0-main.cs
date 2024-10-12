// 0-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Zombie class
        Zombie newObject = new Zombie();

        // Output the type of the object
        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        // Output the string representation of the object
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
