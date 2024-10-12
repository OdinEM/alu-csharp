// 1-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Zombie class
        Zombie newObject = new Zombie();

        // Output the type of the object and the health field
        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}
