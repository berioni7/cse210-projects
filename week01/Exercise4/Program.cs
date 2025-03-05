using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
            List<int> numbers = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Write one number: ");
            int number;
            
          
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid answer. Provide a correct number: ");
            }

            numbers.Add(number);
        }

        int sum = numbers.Sum();
        Console.WriteLine("\nThe total is: " + sum);

        double average = numbers.Average();
        Console.WriteLine("The average is: " + average.ToString("F2")); 

        int maxNumber = numbers.Max();
        Console.WriteLine("The largest number is: " + maxNumber);
    }
}