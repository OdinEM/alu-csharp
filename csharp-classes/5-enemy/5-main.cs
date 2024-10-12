// 5-main.cs
using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject1;
        Enemies.Zombie newObject2;

        try
        {
            newObject1 = new Enemies.Zombie(10);
            newObject1.Name = "Ed"; // Setting the name to "Ed"
            Console.WriteLine(newObject1.ToString()); // Output the details of newObject1
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); // Handle any exceptions
        }

        try
        {
            newObject2 = new Enemies.Zombie(98); // Creating a Zombie with health 98
            Console.WriteLine(newObject2.ToString()); // Output the details of newObject2
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message); // Handle any exceptions
        }
    }
}
