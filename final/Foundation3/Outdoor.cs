public class Outdoor : Event
{
    private string _weather;

    public void SetWeather(string weather)
    {
        this._weather = weather;
    }

    public string DisplayOutdoorDetails()
    {
        return $"Title: {_title}\nDate: {_date}\nTime: {_time}\nDescription: {_description}\nAddress: {_address}\nWeather: {_weather}";
    }
}