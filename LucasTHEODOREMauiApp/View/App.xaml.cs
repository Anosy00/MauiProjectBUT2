using CommunityToolkit.Maui.Views;
using LucasTHEODOREMauiApp.View;

namespace LucasTHEODOREMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GifPage), typeof(GifPage));

            MainPage = new AppShell();
        }
    }
}
