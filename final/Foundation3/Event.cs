using System.Reflection;
using Microsoft.VisualBasic;

public class Event
{
    protected string title;
    protected string date;
    protected string time;
    protected string description;
    protected string address;
    protected string typeOfEvent;
    // This will also do RSVP.
    protected int numberOfAttendees;



    public void GetTitle(string title)
    {
        this.title = title;
    }

    public void GetDate(string date)
    {
        this.date = date;
    }

    public void GetTime(string time)
    {
        this.time = time;
    }

    public void GetDescription(string description)
    {
        this.description = description;
    }
    
    public void GetAddress(string address)
    {
        this.address = address;
    }
    
    public void GetNumberOfAttendees(int numberOfAttendees)
    {
        this.numberOfAttendees = numberOfAttendees;
    }
}