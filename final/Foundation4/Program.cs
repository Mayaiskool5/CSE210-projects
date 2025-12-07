using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("4/3/2022", 60, "Running", 10);
        Biking biking = new Biking("4/7/2022", 30, "Biking", 10);
        Swimming swimming = new Swimming("4/12/2022", 30, "Swimming", 5);

        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}