using CommToolMauiApp.ViewModels;

namespace CommToolMauiApp.Views;

public partial class NetworkCheckPage : ContentPage
{
    public NetworkCheckPage(NetworkCheckViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
