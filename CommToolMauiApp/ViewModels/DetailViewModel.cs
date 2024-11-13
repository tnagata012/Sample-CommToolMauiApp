using CommToolMauiApp.Model;
using CommToolMauiApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommToolMauiApp.ViewModels;

[QueryProperty(nameof(Item), nameof(Item))]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    public partial Item Item { get; set; }

    [RelayCommand]
    private async Task BackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    private async Task GoToAnotherAsync()
    {
        await Shell.Current.GoToAsync($"../{nameof(AnotherPage)}");
    }
}
