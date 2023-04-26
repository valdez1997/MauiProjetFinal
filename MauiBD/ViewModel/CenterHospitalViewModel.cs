

using CommunityToolkit.Mvvm.ComponentModel;
using MauiBD.Model;
using MauiBD.Service;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiBD.ViewModel;

public partial class CenterHospitalViewModel:BaseViewModel
{
    public ObservableCollection<Hospital> Hospitals { get; set; } = new();
    ServiceHospital ServiceHospital;

    public bool First { get; set; } = true;

    [ObservableProperty]
    bool isRefreshing;
    public ICommand GetHospitalCommand { get; private set; }
    public CenterHospitalViewModel(ServiceHospital serviceHospital)
    {
        this.ServiceHospital = serviceHospital;
        GetHospitalCommand = new Command(GetHospitalAsync);
    }
    private async void GetHospitalAsync()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            var listhospital = await ServiceHospital.GetHospital();
            if (Hospitals.Count != 0)
                Hospitals.Clear();
            foreach (var hospital in listhospital)
            {
                Hospitals.Add(hospital);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "Impossible de recuperer la liste des hopitaux", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }
}
