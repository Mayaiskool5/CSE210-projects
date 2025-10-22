using System;

public class JournalEntry
    {
       //Propieties
       public string _message  = "";
       public string _response= "";
       public string _date = DateTime.Now.ToString("dd-MM-yyyy");

       public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_message}");
        //Convert beginning of the sentence into Capital.
        Console.WriteLine(char.ToUpper(_response[0]) + _response.Substring(1));
        //Example: 
        //Date: 04/01/2023 - Prompt: What is the funniest thing that happened to you today?
        //I fell down the stairs.

        }
    
    }