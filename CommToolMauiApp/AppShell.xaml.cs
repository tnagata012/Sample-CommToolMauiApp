using CommToolMauiApp.Views;

namespace CommToolMauiApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute($"{nameof(MainPage)}/{nameof(DetailPage)}", typeof(DetailPage));
        Routing.RegisterRoute($"{nameof(MainPage)}/{nameof(DetailPage)}/{nameof(AnotherPage)}", typeof(AnotherPage));
    }
}
