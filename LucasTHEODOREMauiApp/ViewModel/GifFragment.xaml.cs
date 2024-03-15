using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTHEODOREMauiApp.View;

public partial class GifFragment : ContentPage
{
    public GifFragment()
    {
        InitializeComponent();
    }

    private async void Button_OnClicked(object? sender, EventArgs e)
    {
        ContentPage page = new MainPage();
        await Navigation.PushAsync(page);
    }
}