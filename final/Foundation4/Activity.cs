using System; 

public abstract class Activity
{
    // Storing the date, minutes, and type of activity
    protected string _date; 
    protected double _minutes; 
    protected string _type;

    public Activity(string date, double minutes, string type)
    {
        _date = date;
        _minutes = minutes; 
        _type = type;
    }

    // Summary of each activity
    public string GetSummary()
    {
        return $"{_date} {_type} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }


    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}