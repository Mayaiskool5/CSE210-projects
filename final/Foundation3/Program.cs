using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture();
        lecture.GetTitle("Revise and Rejuvinate");
        lecture.GetDate("10/30/2024");
        lecture.GetTime("10:00 AM");
        lecture.GetDescription("A deeper discussion on revising your thoughts and rejuvinating your health.");
        lecture.GetAddress("The Torch, 2847 Flame Ave, Havana");
        lecture.SetSpeaker("Gerold");
        lecture.SetCapacity(100);
        lecture.GetNumberOfAttendees(75);
        Console.WriteLine(lecture.DisplayLectureDetails());
        Console.WriteLine();

        Reception reception = new Reception();
        reception.GetTitle("Sheryl's Wedding");
        reception.GetDate("04/10/2021");
        reception.GetTime("4:00 PM");
        reception.GetDescription("Please join us for the wedding of Steve Jerome and Sheryl Astle, in celebration of their love.");
        reception.GetAddress("The Lofts, 4873 Flower Ave, Lincoln");
        reception.SetRSVP("100");
        reception.GetNumberOfAttendees(100);
        Console.WriteLine(reception.DisplayReceptionDetails());
        Console.WriteLine();

        Outdoor outdoorEvent = new Outdoor();
        outdoorEvent.GetTitle("Easter Egg Hunt");
        outdoorEvent.GetDate("04/5/2026");
        outdoorEvent.GetTime("9:30 AM");
        outdoorEvent.GetDescription("Come join us for next years Easter Egg hunt EGGstraviganza!");
        outdoorEvent.GetAddress("Bunny Burrow, 1295 Bunny Lane, Pole");
        outdoorEvent.SetWeather("Partly Cloudy");
        outdoorEvent.GetNumberOfAttendees(300);
        Console.WriteLine(outdoorEvent.DisplayOutdoorDetails());
        Console.WriteLine();
    }
}