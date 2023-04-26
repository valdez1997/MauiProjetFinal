

using MauiBD.Model;
using System.Net.Http.Json;

namespace MauiBD.Service;

public class ArticleService
{

    HttpClient client;
    List<Articles> articleslist = new();
    public ArticleService()
    {
        client = new HttpClient();
    }

    public async Task<List<Articles>> GetArticles()
    {
        var response = await client.GetAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/posts");
        if (response.IsSuccessStatusCode)
        {
            articleslist = (await response.Content.ReadFromJsonAsync<ArticleResult>()).posts;
        }
        return articleslist;
    }
}
