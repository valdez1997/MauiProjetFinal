using MauiBD.ViewModel;

namespace MauiBD.View;

public partial class ArticlesPage : ContentPage
{
    ArticleViewModel articleViewModel;
    public ArticlesPage(ArticleViewModel articleViewModel)
    {
        InitializeComponent();
        this.articleViewModel = articleViewModel;
        BindingContext = articleViewModel;
    }

    // conserver la page par defaut au lancement de l'application
    protected  override  void OnAppearing()
    {
        if (articleViewModel.First && articleViewModel.GetArticleCommand.CanExecute(null)) 
        {
             articleViewModel.GetArticleCommand.Execute(null);
            articleViewModel.First=false;
        }
        base.OnAppearing();
        
    }
}