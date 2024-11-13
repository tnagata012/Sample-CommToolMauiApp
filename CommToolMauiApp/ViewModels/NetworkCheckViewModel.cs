using CommToolMauiApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommToolMauiApp.ViewModels;

public partial class NetworkCheckViewModel : ObservableObject
{
    private readonly IConnectivity _connectivity;

    public NetworkCheckViewModel(IConnectivity connectivity)
    {
        _connectivity = connectivity;
    }

    [RelayCommand]
    private async Task CheckInternetAsync()
    {
        var hasInternet = _connectivity?.NetworkAccess == NetworkAccess.Internet;
        var mainPage = Application.Current.Windows[0].Page;
        await mainPage.DisplayAlert("Has Internet", hasInternet ? "YES!" : "NO!", "OK");
    }

    [RelayCommand]
    private async Task GoToAnotherAsync()
    {
        await Shell.Current.GoToAsync($"{nameof(AnotherPage)}");
    }
}
