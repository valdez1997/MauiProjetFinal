using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class EditPassword1Page : ContentPage
{

	public EditPassword1Page(EditPassword1ViewModel ViewModel)
	{
		InitializeComponent();
		BindingContext= ViewModel;
	}
}