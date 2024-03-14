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

        /*private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/
        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            ContentPage page = new GifPage();
            await Navigation.PushAsync(page);
        }
    }

}
