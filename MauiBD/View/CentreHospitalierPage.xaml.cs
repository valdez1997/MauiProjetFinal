using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class CentreHospitalierPage : ContentPage
{
    CenterHospitalViewModel centerHospitalViewModel;
	public CentreHospitalierPage(CenterHospitalViewModel centerHospitalViewModel)
	{
        
		InitializeComponent();
        this.centerHospitalViewModel = centerHospitalViewModel;
        BindingContext=centerHospitalViewModel;
	}
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Rdv2Page));
    }
    protected override void OnAppearing()
    {
        if (centerHospitalViewModel.First && centerHospitalViewModel.GetHospitalCommand.CanExecute(null))
        {
            centerHospitalViewModel.GetHospitalCommand.Execute(null);
            centerHospitalViewModel.First = false;
        }
        base.OnAppearing();

    }
}