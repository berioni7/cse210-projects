using System;

class Program
{
    static void Main(string[] args)
    {
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        void PromptUserName()
        {
            Console.WriteLine("Write your User's name");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}");
        }

        int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?");
            string numbers = Console.ReadLine();
            int userNumber = int.Parse(numbers);
            return userNumber;
        }

        int SquareNumber(int number)
        {
            return number * number;
        }

        void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"Hello {userName}, your favorite number squared is: {squaredNumber}");
        }

        DisplayWelcome();
        PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult("User", squaredNumber);  
    }
}
