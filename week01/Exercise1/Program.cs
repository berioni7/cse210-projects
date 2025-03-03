using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your first name: ");
        string first = Console.ReadLine();  

        Console.WriteLine("Write your second name: ");  
        string second = Console.ReadLine();  

        Console.WriteLine($"{second}, {first} {second}");  
    }
}
