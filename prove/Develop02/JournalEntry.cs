using System;

public class JournalEntry
{
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _promptGenerator = "";
    public string _journalEntry = "";
    public string _journalFile = "";


    public JournalEntry()
    {
    }

    // Display:
    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_promptGenerator}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }

}