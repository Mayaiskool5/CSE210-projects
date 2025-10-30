using System;
using System.Collections.Generic;

//Single word and whether it is shown or hidden.

public class Word
{

    public List<int> listLenght = new List<int>();

    public List<int> hiddenWords = new List<int>()
    {};
    
    public List<string> matC6V24List = new List<string>()
    {
        "No",
        "man",
        "can",
        "serve",
        "two",
        "masters:", 
        "for", 
        "either",
        "he",
        "will",
        "hate",
        "the",
        "one,",
        "and",
        "love",
        "the",
        "other;",
        "or",
        "else",
        "he",
        "will",
        "hold",
        "to",
        "the",
        "one,",
        "and",
        "despise",
        "the",
        "other.",
        "Ye",
        "cannot",
        "serve",
        "God",
        "and",
        "mammon."
    };

    public List<string> johnC3V5List = new List<string>()
    {
        "Jesus",
        "answered,",
        "Verily,",
        "verily,",
        "I",
        "say",
        "unto",
        "thee,",
        "Except",
        "a",
        "man",
        "be",
        "born",
        "of",
        "water",
        "and",
        "of",
        "the",
        "Spirit,",
        "he",
        "cannot",
        "enter",
        "into",
        "the",
        "kingdom",
        "of",
        "God."
    };

    public List<string> dAndCC25V12 = new List<string>()
    {
        "For", 
        "my", 
        "soul", 
        "delighteth", 
        "in", 
        "the", 
        "song", 
        "of", 
        "the", 
        "heart;", 
        "yea,", 
        "the", 
        "song", 
        "of", 
        "the",
        "righteous",
        "is",
        "a",
        "prayer", 
        "into", 
        "me,", 
        "and", 
        "it", 
        "shall", 
        "be", 
        "answered", 
        "with", 
        "a", 
        "blessing", 
        "upon", 
        "their", 
        "heads."
    };

    public void pickThreeWords()
    {
        for (int i = 0; i < 3;)
        {
            int number = RandomNumberGenerator();
            if(hiddenWords.Contains(number) == false)
            {
                hiddenWords.Add(number);
                i++;
            }
            if (hiddenWords.Count == listLenght[0])
            {
                break;
            }
        }
        
    }

    public int RandomNumberGenerator()
    {
        Random random = new Random();
        int number = random.Next(0, listLenght[0]);
        return number;
    }

    internal object wordCount(List<string> list)
    {
        int count = list.Count();
        listLenght.Add(count);
        return count;
    }
}