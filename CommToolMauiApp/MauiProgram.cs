using CommToolMauiApp.ViewModels;
using CommToolMauiApp.Views;

namespace CommToolMauiApp;

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

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<DetailViewModel>();
        builder.Services.AddSingleton<CounterViewModel>();
        builder.Services.AddTransient<NetworkCheckViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<DetailPage>();
        builder.Services.AddSingleton<CounterPage>();
        builder.Services.AddTransient<NetworkCheckPage>();
        builder.Services.AddSingleton<FlexLayoutPage>();

        return builder.Build();
    }
}
