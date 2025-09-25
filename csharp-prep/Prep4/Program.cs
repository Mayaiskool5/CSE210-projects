using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);

            // Only add the number to the list if it is not 0
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }

        // 1. Compute the Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // 2. Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 3. Fine the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                //if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}