using System;
using System.Collections.Generic;

public class Journal{

    public string _name = "";
    //List of Entries
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void Display(){

        //Convert to capital.
        Console.WriteLine($"Name: "+char.ToUpper(_name[0]) + _name.Substring(1));

        //Name.
        Console.WriteLine($"Entries:");

        foreach (JournalEntry elemEntry in _entries)
        {
         //Display.
         elemEntry.Display();
         
        }
    }

    }