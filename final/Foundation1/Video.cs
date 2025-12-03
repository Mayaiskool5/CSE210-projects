public class Video
{
    private string title;
    private string youtuber;
    private int length; // Length of video

    public void getLength(int minutes, int seconds)
    {
        length = (minutes * 60) + seconds;
    }
    public void getTitle(string Title)
    {
        title = Title;
    }
    public void getYoutuber(string Youtuber)
    {
        youtuber = Youtuber;
    }
    public string returnInfo()
    {
        return $"Title: {title}\n Youtuber: {youtuber}\n Length: {length} seconds \n Comments:";
    }

}