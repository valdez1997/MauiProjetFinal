using MauiBD.Constants;
using MauiBD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiBD.Service;

public class ServiceDisplayProfil
{

    HttpClient client;
    
    public ServiceDisplayProfil()
    {
        client=new HttpClient();
    }

    public async Task<UserProfilEnd> GetProfil()
    {
        var user=new UserProfilEnd();
        var response = await client.GetAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/user/"+Constant.Authid);
        if (response.IsSuccessStatusCode)
        {
            user = await response.Content.ReadFromJsonAsync<UserProfilEnd>();
        }
        return user;
        
    }






   
}
