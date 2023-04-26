using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(WelcomeViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    
}