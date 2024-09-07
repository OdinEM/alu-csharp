using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number
        Random random = new Random();
        int number = random.Next(-10000, 10000);

        // Calculate the last digit of the number
        int lastDigit = number % 10;

        // Print the first part of the output
        Console.Write("The last digit of " + number + " is " + lastDigit);

        // Determine and print the corresponding message based on the last digit
        if (lastDigit > 5)
        {
            Console.WriteLine(" and is greater than 5");
        }
        else if (lastDigit == 0)
        {
            Console.WriteLine(" and is 0");
        }
        else
        {
            Console.WriteLine(" and is less than 6 and not 0");
        }
    }
}
