using CommToolMauiApp.ViewModels;

namespace CommToolMauiApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

