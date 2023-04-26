


using MauiBD.Model;
using System.Net.Http.Json;

namespace MauiBD.Service;

public class ServiceHospital
{
    HttpClient client;
    List<Hospital> hospitallist = new();
    public ServiceHospital()
    {
        client = new HttpClient();
    }

    public async Task<List<Hospital>> GetHospital()
    {
        var response = await client.GetAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/hospitals");
        if (response.IsSuccessStatusCode)
        {
            hospitallist = (await response.Content.ReadFromJsonAsync<StatusHospital>()).hospitals;
        }
        else
        {
            return null;
        }
        return hospitallist;
    }






  /*  var client = new HttpClient();
    var request = new HttpRequestMessage(HttpMethod.Get, "https://blooddonation.myhosting.pw/Blood-Donation/public/api/hospitals");
    var response = await client.SendAsync(request);
    response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());*/

}
