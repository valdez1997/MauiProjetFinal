using CommunityToolkit.Mvvm.ComponentModel;
using MauiBD.Model;
using MauiBD.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiBD.ViewModel;

public partial class ProfilViewModel:BaseViewModel
{
    ServiceDisplayProfil serviceDisplayProfil;
    [ObservableProperty]
    bool isRefreshing;

    public bool First { get; set; } = true;
  public UserProfilEnd userprofil { get; set; } = new();

    public ICommand ProfilCommand { get; private set; }
    public ProfilViewModel(ServiceDisplayProfil serviceDisplayProfil)
    {
        this.serviceDisplayProfil= serviceDisplayProfil;
        ProfilCommand = new Command(GetProfilAsync);
    }
    private async void GetProfilAsync()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            userprofil = await serviceDisplayProfil.GetProfil();
            
            
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "Impossible de recuperer la liste des articles", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }
}
