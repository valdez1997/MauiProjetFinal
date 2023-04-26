

using MauiBD.Model;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace MauiBD.Service;

public class LoginService
{
    HttpClient client;
    public LoginService()
    {
        client = new HttpClient();
    }
    public async Task<UserLogin> Postlogin(UserLoginSen item)
    {
       
        var results=new UserLogin();
        try
        {
            string json = JsonConvert.SerializeObject(item);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/login", content);
            //Debug.WriteLine("\t user  successfully saved.");

            if (response.IsSuccessStatusCode)
            { 
                Debug.WriteLine("\t user login  successfully saved.");
            var jsonresponse = await response.Content.ReadAsStringAsync();
             results = JsonConvert.DeserializeObject<UserLogin>(jsonresponse);
             
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine( ex.Message);
        }
        return results;
    }

}
