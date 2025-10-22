using System;
using System.Collections.Generic;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        //Get the user data
        //Get Name
            Console.Write("Enter your full name please: ");
            string userName = Console.ReadLine();   
            Journal myJournal = new Journal();

            //Convert to Capital Name.
            myJournal._name = char.ToUpper(userName[0]) + userName.Substring(1);

            List<string> localStorageList = new List<string>();

        bool exitProgram = false;
        while(!exitProgram){

            //List of prompts
            List<string> promptGenerator = new List<string>()
            {
            "Who was the most interesting person I talked to today?",
            "What was the highlight of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "List the places I have been to today.",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why.",
            "What was the craziest thing you did today?",
            "What was the best meal of the day today and what was it?",
            "Who made you feel good today?",
            "What is something you learned today?",
            "What is the funniest thing that happened today?",
            "How did you procrastinate on important tasks today?",
            "What scripture just popped into your head right now?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "What steps did you take today towards a goal you are working on?",
            "How did you show love to someone today?",
            "How would you describe your spirituality today?",
            "Identify two times that you felt challenged today.",
            "If you could only accomplish three things tomorrow, what would they be?",
            "What was the most peaceful moment during the day?",
            "Would you change any of the decisions you made today? What would you change them to?",
            "What frightened you today?",
            "If you had another hour during the day, how would you have spent it?",
            "Reflect on how your body feels. Sore, Stressed, Tired, Energized, How are you feeling?",
            "Did you read a book today? If so what?",
            "Did you watch a movie or TV show today? If so what?"
            };

            //Display the menu
            Console.WriteLine("Which would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string chargedFile= "No";
            string load;
            string choice = Console.ReadLine();
            

            switch (choice)
            {

            // Write: Option 1
                    case "1":

                    //Function to make the elements random inside the list.
                    Random random = new Random();
                    int num = random.Next(0, 6);//Number min 0 and max 6
                    //Entry
                    JournalEntry entry1 = new JournalEntry();
                    entry1._message = promptGenerator[num];
                    Console.WriteLine(entry1._message);
                    //Have the user respond. 
                    Console.Write("Enter your response: ");
                    string userResponse = Console.ReadLine();
                    //Convert first letter to Capital.
                    entry1._response = char.ToUpper(userResponse[0]) + userResponse.Substring(1);
                    myJournal._entries.Add(entry1);

                    break;

            // Display: Option 2
                case "2":
                    if(chargedFile == "Yes"){
                    foreach (string item in localStorageList)
                    {
                        Console.WriteLine(item);
                    }
                     myJournal.Display();//Add the entries to the list Journal

                    Console.WriteLine("To save the current list, please save it.");
                    }
                    
                    else if(chargedFile == "No"){
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    
                    myJournal.Display();//Add the entries to the list Journal

                    //Display the Journal information.
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                    Console.WriteLine("To save the current list, please save it.");

                    };

                    break;

            // Load: Option 3
                case "3":
                
                    chargedFile= "No";
                    //Get the file to load
                    Console.Write("What is the file's name? (Ex. myFile.csv) ");
                    load = Console.ReadLine();
                    string filename = load;
                    
                    //Read
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                            Console.WriteLine(line);
                            localStorageList.Add(line);                            
                    }
                    Console.WriteLine("File loaded.");

                    chargedFile= "Yes";
                    break;


            
            // Save: Option 4
                case "4":

                    //Get the file to save
                    Console.Write("What is the name of the file? (Ex. theFile.csv) ");
                    string save = Console.ReadLine();
                    
                    //Save the data (to the file "theFile.csv" ^ in this case as stated above).
                    using (StreamWriter outputFile = new StreamWriter(save))
                    {  
                    //Display                 
                        outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        outputFile.WriteLine($"Name: {myJournal._name}");

                        foreach (JournalEntry entry in myJournal._entries)
                        {

                        //Print the prompt and the response.
                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: "+entry._message);
                        outputFile.WriteLine($"{entry._response}");
                        
                        }              
                        outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        
                    };

                    break;
            
            // Exit: Option 5
                case "5":
                    exitProgram = true;
                    break;
                
                default:
                    Console.WriteLine("Oops. Please choose another option.");
                    break;
            }
        
            }
           

        
        
    }
}