using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GetFacts
{
  class Program
  {
    static void Main(string[] args)
    {
      String endpoint = "http://secxbrl.28.io/v1/_queries/public";
      CellStore.Api.DataApi dataAPI = new CellStore.Api.DataApi(endpoint);

      String token = "c3049752-4d35-43da-82a2-f89f1b06f7a4";
      // login .. Alternative step to create a token dynamically
      /*
        CellStore.Api.SessionsApi sessionsAPI = new CellStore.Api.SessionsApi(endpoint);
        dynamic loginResponse = sessionsAPI.Login("example@email.com", "password");
        String token = loginResponse["token"];      
      */

      // list some facts
      dynamic factsResonse = dataAPI.ListFacts(token, ticker: new List<string> { "t" }, 
                                                      fiscalYear: new List<string> { "2014" }, 
                                                      fiscalPeriod: new List<string> { "FY" }, 
                                                      concept: new List<string> { "us-gaap:Assets" });
      dynamic factTable = factsResonse["FactTable"];
      int i = 0;
      foreach (dynamic fact in factTable.Children())
      {
        Console.WriteLine("===========================");
        Console.WriteLine("Fact " + i + ":");
        Console.WriteLine(JsonConvert.SerializeObject(fact, Formatting.Indented));
        i++;
      }

      Console.ReadKey();
    }
  }
}
