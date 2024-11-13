using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommToolMauiApp.ViewModels;

public partial class CounterViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Rotation))]
    public partial int Count { get; set; }

    public double Rotation => Count % 360;

    [RelayCommand]
    private void Increment()
    {
        Count += 1;
    }

    [RelayCommand]
    private void Clear()
    {
        Count = 0;
    }
}
