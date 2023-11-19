namespace BlazorApp1.Models;

internal class WeatherForecast
{
    public DateOnly Date
    {
        get;
        set;
    }

    public int TemperatureC
    {
        get;
        set;
    }

    public string? Summary
    {
        get;
        set;
    }

    public int TemperatureF
    {
        get => 32 + (int)(TemperatureC / 0.5556);
    }
}
