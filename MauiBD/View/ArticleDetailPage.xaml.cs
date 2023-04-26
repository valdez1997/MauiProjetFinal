using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class ArticleDetailPage : ContentPage
{
	public ArticleDetailPage(ArticleDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext=viewModel;
	}
}