using Microsoft.Extensions.Logging;
using minterm_Project_main.Services;
using minterm_Project_main.ViewModels;
namespace minterm_Project_main;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<EmployeService>();
        builder.Services.AddSingleton<DashboardViewModel>();
        return builder.Build();
    }
}