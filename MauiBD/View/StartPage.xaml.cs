using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class StartPage : ContentPage
{
    public StartPage(StartViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}