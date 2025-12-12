public class Video
{
    private string _title;
    private string _youtuber;
    private int _length; // Length of video

    public void getLength(int minutes, int seconds)
    {
        _length = (minutes * 60) + seconds;
    }
    public void getTitle(string Title)
    {
        _title = Title;
    }
    public void getYoutuber(string Youtuber)
    {
        _youtuber = Youtuber;
    }
    public string returnInfo()
    {
        return $"Title: {_title}\n Youtuber: {_youtuber}\n Length: {_length} seconds \n Comments:";
    }

}