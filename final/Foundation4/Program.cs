using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("6/3/2024", 40, "Running", 10);
        Biking biking = new Biking("6/7/2024", 60, "Biking", 40);
        Swimming swimming = new Swimming("6/10/2024", 30, "Swimming", 6);

        activities.Add(running);
        activities.Add(biking);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}