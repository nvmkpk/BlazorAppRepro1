namespace BlazorApp1.Models;

public class CounterModel
{
    public int CurrentCount
    {
        get;
        set;
    }

    public DateOnly? Date
    {
        get;
        set;
    }

    internal void Increment()
    {
        this.CurrentCount++;
    }
}