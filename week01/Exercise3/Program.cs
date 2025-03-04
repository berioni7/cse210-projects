using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        int magic = 6;
        Console.WriteLine("What is the magic number(1-10)? ");
        string input = Console.ReadLine();
        int numbers = int.Parse(input);
        while (numbers != magic)
        {
            Console.WriteLine("Try again: ");
            numbers = int.Parse(Console.ReadLine());
            if (numbers == magic)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (numbers == 5)
            {
            Console.WriteLine("Higher");
            }
            else if (numbers == 4)
            {
            Console.WriteLine("Higher");
            }
            else if (numbers == 3)
            {
            Console.WriteLine("Higher");
            }
            else if (numbers == 2)
            {
            Console.WriteLine("Higher");
            }
            else if (numbers == 1)
            {
            Console.WriteLine("Higher");
            }
            else
            {
            Console.WriteLine("Lower");
            }
        }
    }
}