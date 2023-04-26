using MauiBD.Constants;
using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class ProfilPage : ContentPage
{
	ProfilViewModel viewModel;
	public ProfilPage(ProfilViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext=viewModel;
	}
    protected override void OnAppearing()
    {
        if (viewModel.First && viewModel.ProfilCommand.CanExecute(null))
        {
            viewModel.ProfilCommand.Execute(null);
            viewModel.First = false;
        }
        base.OnAppearing();

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.DisplayAlert("Infos","Valdy"+Constant.Authid,"OK");
    }
}