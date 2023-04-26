

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiBD.Model;
using MauiBD.Service;
using MauiBD.View;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MauiBD.ViewModel;

public partial class ArticleViewModel:BaseViewModel
{
    ArticleService articleService;

   
    public ObservableCollection<Articles> Article { get; set; } = new();
    public ICommand GetArticleCommand { get; private set; }

    [ObservableProperty]
    bool isRefreshing;

    public bool First { get; set; } = true;

    public ICommand DetailCommand { get; private set; }
    public ArticleViewModel(ArticleService articleService)
    {
        this.articleService = articleService;
        GetArticleCommand = new Command(GetArticlesAsync);
        DetailCommand = new Command<Articles>(GoToDetailAsync);
    }
    
    private async void GetArticlesAsync()
    {
        if (IsBusy)
            return;
        try
        {
            IsBusy = true;
            var listarticle = await articleService.GetArticles();
            if (Article.Count != 0)
                Article.Clear();
            foreach (var article in listarticle)
            {
                Article.Add(article);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "Impossible de recuperer la liste des articles", "OK");
        }
        finally
        {
            IsBusy = false;
            IsRefreshing= false;
        }

    }
   
  private  async void GoToDetailAsync(Articles article)
    {
        if(article is null)
            return;
        await Shell.Current.GoToAsync($"{nameof(ArticleDetailPage)}",true,
            new Dictionary<string, object>
            {
                {"Article",article }
            });
    }
}
