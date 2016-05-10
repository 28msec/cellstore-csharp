using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace GetFacts
{
  class Program
  {
    static void Main(string[] args)
    {
      String endpoint = "http://secxbrl.28.io/v1/_queries/public";
      CellStore.Api.DataApi dataAPI = new CellStore.Api.DataApi(endpoint);

      String token = "example-token";
      // login .. Alternative step to create a token dynamically
      /*
        CellStore.Api.SessionsApi sessionsAPI = new CellStore.Api.SessionsApi(endpoint);
        dynamic loginResponse = sessionsAPI.Login("example@email.com", "password");
        String token = loginResponse["token"];      
      */
       
      byte[] filing = File.ReadAllBytes(@"filing.zip");

      dynamic result = dataAPI.AddFilings(token: token, filing: filing, contentType: "application/xbrlx", profileName: "SEC");

      Console.WriteLine(JsonConvert.SerializeObject(result));
      Console.ReadKey();
    }    
  }
}