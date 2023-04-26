

using CommunityToolkit.Mvvm.Input;
using MauiBD.View;

namespace MauiBD.ViewModel;

public partial class MainViewModel:BaseViewModel
{
    public MainViewModel()
    {

    }
    [RelayCommand]
    async Task Welcome1()
    {
        await Shell.Current.GoToAsync($"{nameof(WelcomePage)}");
    }
}
