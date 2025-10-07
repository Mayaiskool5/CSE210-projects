using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    public List<JournalEntry> _journal = new List<JournalEntry>();

    private string _filename;

    public Journal()
    {
    }

    // Displays each journal entry
    public void Display()
    {
        Console.WriteLine("\n ~~~Journal Entries~~~ ");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n~~~ End ~~~");
    }

    public void CreateJournalFile()
    // Checking if txt file is created, if it is not ,create one.
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _filename = userInput + ".txt";

        if (!File.Exists(_filename))
        {
            File.CreateText(_filename);
            Console.Write($"\n~~~ {_filename} has been created! ~~~\n");
            Console.Write("~~~  Your journal entries have been saved. ~~~\n");
            SaveToFile(_filename);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n~~~ {_filename} already exits. ~~~\n");
            Console.Write("~~~  Your journal entries have been added. ~~~\n");
            AppendJournalFile(_filename);
        }
    }
    public void SaveToFile(string _filename)
    // Saving journal to txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string _filename)
    // Saving a new entry to journal txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_filename, append: true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadJournalFile()
    // Checking if txt file is created and load it into the list.  
    // This should replace the current information in the list
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _filename = userInput + ".txt";

        if (File.Exists(_filename))
        {
            List<string> readText = File.ReadAllLines(_filename).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                JournalEntry entry = new JournalEntry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];

                _journal.Add(entry);
            }
        }
    }


    public void CreateJSON(string userInput)
    // Creating a JSON file 
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (JournalEntry journalEntry in _journal)
        {
            _data.Add(new JsonItem()
            {
                ID = journalEntry._entryNumber,
                Date = journalEntry._dateTime,
                Prompt = journalEntry._journalPrompt,
                Entry = journalEntry._journalEntry
            });
        }

        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

}