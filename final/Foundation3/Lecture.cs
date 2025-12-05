public class Lecture : Event
{
    // Limited Capacity and a speaker
    private int capacity;
    private string speaker;

    

    public void SetCapacity(int capacity)
    {
        this.capacity = capacity;
    }
    public void SetSpeaker(string speaker)
    {
        this.speaker = speaker;
    }

    public bool IsFull()
    {
        return numberOfAttendees >= capacity;
    }
    public string DisplayLectureDetails()
    {
        if (IsFull() == true)
        {
            return $"Lecture by {speaker} is full. Current Attendees: {numberOfAttendees}/{capacity}.";
        }

        return $"Title: {title}, Speaker: {speaker}\nCurrent attendees: {numberOfAttendees}/{capacity}\nDate: {date}\nTime: {time}\nDescription: {description}\nAddress: {address}";
    }

}