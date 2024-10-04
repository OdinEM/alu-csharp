using System;

class Program
{
    static void Main(string[] args)
    {
        Rating rating;

        rating = Rating.Great;

        Console.WriteLine("Score: " + rating);         // Output: Score: Great
        Console.WriteLine("Score: " + (int)rating);    // Output: Score: 1
    }
}
