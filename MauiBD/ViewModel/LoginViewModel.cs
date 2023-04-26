
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBD.Constants;
using MauiBD.Model;
using MauiBD.Service;
using MauiBD.View;
using System.Windows.Input;

namespace MauiBD.ViewModel;

public partial class LoginViewModel:BaseViewModel
{

    
    LoginService loginservice;

    [ObservableProperty]
    public string email;

    [ObservableProperty]
    public string password;

    public ICommand RegisterCommand { get; private set; }
    public LoginViewModel(LoginService loginService)
    {
        this.loginservice = loginService;
        RegisterCommand = new Command(Regist);
    }
    [RelayCommand]
    async void EditPassword()
    {
        //Shell.Current.Navigation.PushAsync(new View.EditPasswordPage());
        await Shell.Current.GoToAsync($"{nameof(EditPassword1Page)}");
    }
    
    async void Regist()
    {
        // await Shell.Current.Navigation.PushAsync(new View.RegisterPage());
        //  await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
        await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");

    }
    [RelayCommand]
    public async Task Login()
    {

        var user = new UserLoginSen
        {
            email = Email,
            password = Password
        };
        var statu = (await loginservice.Postlogin(user)).status;
       var accesToken = (await loginservice.Postlogin(user)).token;
        Constant.AuthToken = accesToken;
        Constant.AuthName = (await loginservice.Postlogin(user)).name;
        var ids = (await loginservice.Postlogin(user)).id;
        Constant.Authid= ids;


        if ((Email == null) && (Password == null))
        {
            await Shell.Current.DisplayAlert("Error", "Veuillez remplir les champs Email et Password", "OK");
        }
        if (Password.Length < 7)
        {
            await Shell.Current.DisplayAlert("Error","Mot de passe tres peu sécurisé","OK");
        }
        
        else if(statu=="true")
        {

            await Shell.Current.GoToAsync($"//Home");

        }
        else if(statu=="false")
        {
            await Shell.Current.DisplayAlert("Error", "Email ou Mot de passe invalide", "OK");
        }
        else
        {
            await Shell.Current.DisplayAlert("Error","Verifier bien !!!","OK");
        }

    }
}
