using System.Reflection;
using Microsoft.VisualBasic;

public class Event
{
    protected string _title;
    protected string _date;
    protected string _time;
    protected string _description;
    protected string _address;
    protected string _typeOfEvent;
    // This will also do RSVP.
    protected int _numberOfAttendees;



    public void GetTitle(string title)
    {
        this._title = title;
    }

    public void GetDate(string date)
    {
        this._date = date;
    }

    public void GetTime(string time)
    {
        this._time = time;
    }

    public void GetDescription(string description)
    {
        this._description = description;
    }
    
    public void GetAddress(string address)
    {
        this._address = address;
    }
    
    public void GetNumberOfAttendees(int numberOfAttendees)
    {
        this._numberOfAttendees = numberOfAttendees;
    }
}