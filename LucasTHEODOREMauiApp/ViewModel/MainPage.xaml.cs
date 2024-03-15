using LucasTHEODOREMauiApp.View;

namespace LucasTHEODOREMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            
            
        }
        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            ContentPage page = new GifFragment();
            await Navigation.PushAsync(page);
        }
    }

}
