using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.getTitle("We Won Every Game at the State Fair!");
        video1.getYoutuber("Dude Perfect");
        video1.getLength(14, 43); // 14 minutes and 43 seconds in length

        Comments comments1 = new Comments();
        comments1.addComment("James", "Great video!");
        comments1.addComment("Billy", "Love you guys!!");
        comments1.addComment("Thomas", "Soo many stuffies!");
        comments1.addComment("Blaire", "Duuuuuuuuuuude!!!!");
        Console.WriteLine("");

        Console.WriteLine(video1.returnInfo());
        Console.WriteLine(comments1.returnComments());

        Video video2 = new Video();
        video2.getTitle("100 Layers of CRAYON vs DUCT TAPE!");
        video2.getYoutuber("Preston");
        video2.getLength(20, 15); // 20 minutes and 15 seconds in length

        Comments comments2 = new Comments();
        comments2.addComment("Trey", "There is no way!");
        comments2.addComment("Ivan", "I can't believe you were able to get through all those layers!");
        comments2.addComment("Hank", "Who knew they could be that tough!");
        comments2.addComment("Wally", "PREEEEESTOOOOON!");
        Console.WriteLine("");

        Console.WriteLine(video2.returnInfo());
        Console.WriteLine(comments2.returnComments());

        Video video3 = new Video();
        video3.getTitle("I Tried Every Viral Tik Tok Food Hack");
        video3.getYoutuber("Nick DiGiovanni");
        video3.getLength(11, 7); //  11 minutes and 7 seconds in length

        Comments comments3 = new Comments();
        comments3.addComment("Jane", "Skittles popcorn! No way!");
        comments3.addComment("Naomi", "So many awesome hacks!!");
        comments3.addComment("Chad", "Now I know, hmf.");
        comments3.addComment("Yolanda", "That's wild!");
        Console.WriteLine("");

        Console.WriteLine(video3.returnInfo());
        Console.WriteLine(comments3.returnComments());
        Console.WriteLine("");
        Console.WriteLine("The End!");
    }
}