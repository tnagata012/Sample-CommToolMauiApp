using CommToolMauiApp.ViewModels;

namespace CommToolMauiApp.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
