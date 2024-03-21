using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace ExamenApp1
{
    public class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers((handlers) =>
                {
                    // Configure handlers
                });

            return builder.Build();
        }
    }

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Configurar una nueva página NavigationPage con MainPage como su página raíz
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
