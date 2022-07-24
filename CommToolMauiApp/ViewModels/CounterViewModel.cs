using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommToolMauiApp.ViewModels;

public partial class CounterViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Rotation))]
    private int _count;

    public double Rotation => _count % 360;

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
