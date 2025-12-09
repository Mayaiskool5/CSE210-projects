public class Lecture : Event
{
    // Limited Capacity and a speaker
    private int _capacity;
    private string _speaker;

    

    public void SetCapacity(int capacity)
    {
        this._capacity = capacity;
    }
    public void SetSpeaker(string speaker)
    {
        this._speaker = speaker;
    }

    public bool IsFull()
    {
        return _numberOfAttendees >= _capacity;
    }
    public string DisplayLectureDetails()
    {
        if (IsFull() == true)
        {
            return $"Lecture by {_speaker} is full. Current Attendees: {_numberOfAttendees}/{_capacity}.";
        }

        return $"Title: {_title}, Speaker: {_speaker}\nCurrent attendees: {_numberOfAttendees}/{_capacity}\nDate: {_date}\nTime: {_time}\nDescription: {_description}\nAddress: {_address}";
    }

}