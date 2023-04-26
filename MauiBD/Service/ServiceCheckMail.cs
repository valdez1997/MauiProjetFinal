

using MauiBD.Model;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace MauiBD.Service;

public class ServiceCheckMail
{
    HttpClient client;
    public ServiceCheckMail()
    {
        client = new HttpClient();
    }
    public async Task<AnswerGet> PostEmail(UserSendEmail items)
    {
        var results = new AnswerGet();
        try
        {
            string json = JsonConvert.SerializeObject(items);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://blooddonation.myhosting.pw/Blood-Donation/public/api/forgotpassword/get/email", content);
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine("\t user login  successfully saved.");
                var jsonresponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<AnswerGet>(jsonresponse);
            }
            else
            {
                return null;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        return results;
    }
}
