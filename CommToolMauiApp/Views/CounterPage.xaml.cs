using CommToolMauiApp.ViewModels;

namespace CommToolMauiApp.Views;

public partial class CounterPage : ContentPage
{
    public CounterPage(CounterViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

