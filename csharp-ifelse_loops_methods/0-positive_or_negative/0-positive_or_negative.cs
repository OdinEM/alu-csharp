using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(-100, 101);

        Console.Write($"{number} ");

        if (number > 0)
        {
            Console.WriteLine("is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("is negative");
        }
        else
        {
            Console.WriteLine("is zero");
        }
    }
}

