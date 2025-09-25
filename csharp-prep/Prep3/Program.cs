using System;

class Program
{
    static void Main(string[] args)
    {
        //For Part 1 and 2, where the user specified the number...
        //Console.Write("What is the magic number? ");
        //int magicNum = int.Parse(Console.ReadLine());

        //For Part 3, where we use a random number
        Random randomGen = new Random();
        int magicNum = randomGen.Next(1, 101);
        
        int guess = -1;

        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNum > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed correctly!");
            }
        }
    }
}