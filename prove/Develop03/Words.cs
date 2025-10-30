using System;
using System.Collections.Generic;

//Single word and whether it is shown or hidden.

public class Word
{

    public List<int> listLenght = new List<int>();

    public List<int> hiddenWords = new List<int>()
    {};
    
    public List<string> matC28V1920List = new List<string>()
    {
        "19:",
        "Go",
        "ye",
        "therefore,",
        "and",
        "teach",
        "all",
        "nations,",
        "baptizing",
        "them",
        "in",
        "the",
        "name",
        "of",
        "the",
        "Father,",
        "and",
        "of",
        "the",
        "Son,",
        "and",
        "of",
        "the",
        "Holy",
        "Ghost:",
        "20:",
        "Teaching",
        "them",
        "to",
        "observe",
        "all",
        "things",
        "whatsoever",
        "I",
        "have",
        "commanded",
        "you:",
        "and,",
        "lo,",
        "I",
        "am",
        "with",
        "you",
        "alway,",
        "even",
        "unto",
        "the",
        "end",
        "of",
        "the",
        "world.",
        "Amen."
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