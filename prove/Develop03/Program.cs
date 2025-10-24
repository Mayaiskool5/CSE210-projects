using System;
using System.Collections.Generic;

class Program
{
        
    static void Main(string[] args)
    {
        for (int i = 0; i < 1; i++)
        {
            Scriptures scripture = new Scriptures();
            Word word = new Word();
            Console.WriteLine("\n" + "Welcome to the Scripture Memorization App!");
            Console.WriteLine("Which scripture would you like to practice?:");
            Console.WriteLine("1. Matthew 6:24");
            Console.WriteLine("2. John 3:5");
            Console.WriteLine("3. D&C 25:12");
            int selection = Convert.ToInt32(Console.ReadLine());


            if(selection == 1)
            {
                Console.Clear();
                Reference reference = new Reference("Matthew", "6", "24");
                string scriptRef = reference.GetReference();
                scripture.Verses(scriptRef, word.matC6V24List);
                Console.WriteLine("Hit enter to start or type 'quit' to exit.");
                string input = Console.ReadLine();

                bool runProgram = true;
                do
                {
                    word.wordCount(word.matC6V24List); 
                
                    if(input == "quit")
                    {
                        runProgram = false;
                    }
                    else if (input == "")
                    {
                        Console.Clear();
                        word.wordCount(word.matC6V24List);
                        word.pickThreeWords();
                        scripture.HideText(scriptRef, word.matC6V24List, word.hiddenWords);
                        input = Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid command.");
                        input = Console.ReadLine();
                    }

                    if(word.hiddenWords.Count == word.listLenght[0])
                    {
                        runProgram = false;
                    }
                
                }
                while (runProgram == true);
            } else if(selection == 2)
            {
                Console.Clear();
                Reference reference = new Reference("John", "3", "5");
                string scriptRef = reference.GetReference();
                scripture.Verses(scriptRef, word.johnC3V5List);
                Console.WriteLine("Hit enter to start or type 'quit' to exit.");
                string input = Console.ReadLine();

                bool runProgram = true;
                do
                {
                    word.wordCount(word.johnC3V5List); 
                
                    if(input == "quit")
                    {
                        runProgram = false;
                    }
                    else if (input == "")
                    {
                        Console.Clear();
                        word.wordCount(word.johnC3V5List);
                        word.pickThreeWords();
                        scripture.HideText(scriptRef, word.johnC3V5List, word.hiddenWords);
                        input = Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid command.");
                        input = Console.ReadLine();
                    }

                    if(word.hiddenWords.Count == word.listLenght[0])
                    {
                        runProgram = false;
                    }
                
                }
                while (runProgram == true);
            } else if(selection == 3)
            {
                Console.Clear();
                Reference reference = new Reference("Doctrine & Covenants", "25", "12");
                string scriptRef = reference.GetReference();
                scripture.Verses(scriptRef, word.dAndCC25V12);
                Console.WriteLine("Hit enter to start or type 'quit' to exit.");
                string input = Console.ReadLine();

                bool runProgram = true;
                do
                {
                    word.wordCount(word.dAndCC25V12); 
                
                    if(input == "quit")
                    {
                        runProgram = false;
                    }
                    else if (input == "")
                    {
                        Console.Clear();
                        word.wordCount(word.dAndCC25V12);
                        word.pickThreeWords();
                        scripture.HideText(scriptRef, word.dAndCC25V12, word.hiddenWords);
                        input = Console.ReadLine();
                    }
                    else 
                    {
                        Console.WriteLine("Please enter a valid command.");
                        input = Console.ReadLine();
                    }

                    if(word.hiddenWords.Count == word.listLenght[0])
                    {
                        runProgram = false;
                    }
                
                }
                while (runProgram == true);
            } else
            {
                Console.WriteLine("\n" + "Please enter a valid option.");
                i--;
            }
      
            
        
        }
        
    }
}