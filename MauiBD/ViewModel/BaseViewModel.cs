

using CommunityToolkit.Mvvm.ComponentModel;


namespace MauiBD.ViewModel;

public partial class BaseViewModel:ObservableObject
{
    public BaseViewModel()
    {

    }


    [ObservableProperty]
    string authName;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    public bool IsNotBusy => !IsBusy;


}
