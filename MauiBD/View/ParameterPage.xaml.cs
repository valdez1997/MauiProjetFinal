using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class ParameterPage : ContentPage
{
	ParameterViewModel viewModel;
	public ParameterPage(ParameterViewModel viewModel)
	{
		InitializeComponent();
		this.viewModel = viewModel;
		BindingContext= viewModel;
	}
}