using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string percentage = Console.ReadLine();
        int numero = int.Parse(percentage);

        if (numero >= 90)
        {
            Console.WriteLine("You have passed in this class with an A. Congrats!");
        }
        else if (numero >= 80)
        {
            Console.WriteLine("You have passed in this class with a B. Congrats!");
        }
        else if (numero >= 70)
        {
            Console.WriteLine("You have passed in this class with a C. Congrats!");
        }
        else if (numero >= 60)
        {
            Console.WriteLine("You have passed in this class with a D. Congrats!");
        }
        else
        {
            Console.WriteLine("You have not passed in this class. You got an F. Please, keep studying and see you next class!");
        }
    }
}
