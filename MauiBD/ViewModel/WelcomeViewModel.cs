

using CommunityToolkit.Mvvm.Input;
using MauiBD.View;

namespace MauiBD.ViewModel;

public partial class WelcomeViewModel:BaseViewModel
{
    public WelcomeViewModel()
    {
    }
    [RelayCommand]
    async Task Login1()
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
