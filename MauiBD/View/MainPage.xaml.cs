using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class MainPage : ContentPage
{
	

	
    MainViewModel ViewModel;
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        this.ViewModel = viewModel;
        BindingContext = viewModel;
    }

    private void TapWelcome1(object sender, TappedEventArgs e)
    {

        Shell.Current.GoToAsync(nameof(WelcomePage));
    }

}

