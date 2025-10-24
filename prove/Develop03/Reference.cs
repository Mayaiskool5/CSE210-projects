using System;
using System.Collections.Generic;

//Book, Chapter, and Verse info.

public class Reference
{
    private string _books;
   
    private string _chapter;
   
    private string _verse;
   
    public string GetReference()
    {
      string message = $"{_books} {_chapter}:{_verse} ";
      return message;
    }

    public Reference(string book, string chapter, string verse)
    {
         _books = book;
         _chapter = chapter;
         _verse = verse;
    }

}