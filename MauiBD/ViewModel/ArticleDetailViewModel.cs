

using CommunityToolkit.Mvvm.ComponentModel;
using MauiBD.Model;

namespace MauiBD.ViewModel;
[QueryProperty("Article", "Article")]
public partial class ArticleDetailViewModel:BaseViewModel
{
    public ArticleDetailViewModel() 
    { 

    }
    [ObservableProperty]
    Articles article;
}
