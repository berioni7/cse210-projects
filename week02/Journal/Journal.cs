using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I met today?",
        "What was the best part of my day?",
        "How did I see God's hand in my life today?",
        "What was the strongest emotion I felt today?",
        "If I could redo something today, what would it be?"
    };

    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        Entry newEntry = new Entry(prompt, response);
        entries.Add(newEntry);
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter the file name to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Journal successfully saved!");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the file name to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length >= 3)
                {
                    entries.Add(new Entry(parts[1].Trim(), parts[2].Trim()) { Date = parts[0].Trim() });
                }
            }
            Console.WriteLine("Journal successfully loaded!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
