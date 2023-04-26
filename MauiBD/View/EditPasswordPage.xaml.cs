using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class EditPasswordPage : ContentPage
{
	EditPasswordViewModel editPasswordViewModel;
	public EditPasswordPage(EditPasswordViewModel editPasswordViewModel)
	{
		InitializeComponent();
		this.editPasswordViewModel = editPasswordViewModel;
		BindingContext= editPasswordViewModel;
	}
}