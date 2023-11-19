using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages;

public partial class Counter : ComponentBase
{
    [Parameter, SupplyParameterFromForm]
    public CounterModel Model
    {
        get;
        set;
    }

    protected override Task OnInitializedAsync()
    {
        if (this.Model == null)
        {
            this.Model = new();
        }

        return base.OnInitializedAsync();
    }

    private void IncrementCount()
    {
        this.Model.Increment();
    }
}
