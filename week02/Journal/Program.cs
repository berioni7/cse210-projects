using System;

class Program
{
    static void Main()
    {
        Journal myJournal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    myJournal.AddEntry();
                    break;
                case "2":
                    myJournal.DisplayJournal();
                    break;
                case "3":
                    myJournal.SaveToFile();
                    break;
                case "4":
                    myJournal.LoadFromFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
