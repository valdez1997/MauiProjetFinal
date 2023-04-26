

using MauiBD.Constants;
using MauiBD.Model;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MauiBD.Service;

public class LogoutService
{
    HttpClient client;
    public LogoutService()
    {
     client=new HttpClient();
    }
   
    public async Task<AnswerLogout> logout(string accesToken)
    {
        AnswerLogout result = new();
        try
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://blooddonation.myhosting.pw/Blood-Donation/public/api/logout");
            request.Headers.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accesToken);
               // ("Authorization", "Bearer" + Constant.AuthToken);
            //request.Headers.Add("Authorization", "Bearer 2|CJTsXrlRo3npuVQBDupaxMsmmK8k7Q1tqh8UIMp1");
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var responsecontent=await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<AnswerLogout>(responsecontent);
            }
            else
            {
                return null;
            }
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        return result;
            
    }
}
