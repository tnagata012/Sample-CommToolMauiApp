﻿using System.Collections.ObjectModel;
using CommToolMauiApp.Model;
using CommToolMauiApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommToolMauiApp.ViewModels;

public partial class MainViewModel : ObservableValidator
{
    [ObservableProperty]
    public partial ObservableCollection<Item> Items { get; set; } = [];

    [ObservableProperty]
    public partial string Text { get; set; }

    [RelayCommand]
    private void Add()
    {
        ValidateAllProperties();
        if (HasErrors)
            return;

        Items.Add(new Item(Text));
        Text = string.Empty;
    }

    [RelayCommand]
    private void Remove(Item item)
    {
        if (item is null)
            return;

        Items.Remove(item);
    }

    [RelayCommand]
    private async Task NavigateAsync(Item item)
    {
        await Shell.Current.GoToAsync($"./{nameof(DetailPage)}",
            new Dictionary<string, object>
            {
                ["Item"] = item
            });
    }
}
