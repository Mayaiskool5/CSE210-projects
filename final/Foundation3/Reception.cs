public class Reception : Event
{
    private string _RSVP;
    public string DisplayReceptionDetails()
    {
        return $"Title: {_title}\nDate: {_date}\nTime: {_time}\nDescription: {_description}\nAddress: {_address}\nRSVP: {_RSVP}/{_numberOfAttendees}";
    }

    public void SetRSVP(string rsvp)
    {
        this._RSVP = rsvp;
    }
}