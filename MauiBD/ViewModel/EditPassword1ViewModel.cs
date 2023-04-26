

using CommunityToolkit.Mvvm.ComponentModel;
using MauiBD.Model;
using MauiBD.Service;
using MauiBD.View;
using System.Windows.Input;

namespace MauiBD.ViewModel;

public partial class EditPassword1ViewModel:BaseViewModel
{
    ServiceCheckMail serviceCheckMail;

    [ObservableProperty]
    public string mail;

    public EditPassword1ViewModel(ServiceCheckMail serviceCheckMail)
    {
      this.serviceCheckMail = serviceCheckMail;
        CheckCommand = new Command(CheckedEmail);
    }
    public ICommand CheckCommand { get; private set; }
    public async void CheckedEmail()
    {
        var user = new UserSendEmail
        {
            email=Mail
        };
        var Statu = (await serviceCheckMail.PostEmail(user)).status;

        if (Statu =="true")
        {
             await Shell.Current.GoToAsync(nameof(EditPasswordPage));
          //  await Shell.Current.DisplayAlert("Error", Statu, "OK");
        }
        
        else
        {
            await Shell.Current.DisplayAlert("Error", "Email non valide", "OK");
        }

    }
}
