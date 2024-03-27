using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucasTHEODOREMauiApp.ViewModel;

namespace LucasTHEODOREMauiApp.View;

public partial class ApiPage : ContentPage
{
    public ApiPage()
    {
        InitializeComponent();
        var apiViewModel = new ApiPageViewModel();
        BindingContext = apiViewModel;
    }
    
    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        ContentPage page = new GifFragment();
        await Navigation.PushAsync(page);
    }

}