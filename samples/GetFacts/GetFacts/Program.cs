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
      String endpoint = "http://fcavalieri.com:28080/secxbrl/v1/_queries/public";
      CellStore.Api.DataApi dataAPI = new CellStore.Api.DataApi(endpoint);

      String token = "c3049752-4d35-43da-82a2-f89f1b06f7a4";
      // login .. Alternative step to create a token dynamically
      /*
        CellStore.Api.SessionsApi sessionsAPI = new CellStore.Api.SessionsApi(endpoint);
        dynamic loginResponse = sessionsAPI.Login("example@email.com", "password");
        String token = loginResponse["token"];      
      */


      pepVsCocaColaFacts(dataAPI, token);
      attFacts(dataAPI, token);
      cocaColaFacts(dataAPI, token);
    }

    private static void pepVsCocaColaFacts(CellStore.Api.DataApi dataAPI, String token)
    {
        // dimensions to query : 
        //    AssetsCurrent for Pepsi and Coca Cola for FY 2011 to 2014
        Dictionary<string, List<string>> dimensions =
            new Dictionary<string, List<string>>
            {
                { "xbrl:Concept", new List<string> { "us-gaap:AssetsCurrent" } },
                { "xbrl:Entity", new List<string> { "http://www.sec.gov/CIK 0000077476",
                                                    "http://www.sec.gov/CIK 0000021344" } },
                { "xbrl28:FiscalPeriod", new List<string> { "FY" } },
                { "xbrl28:FiscalYear", new List<string> { "2011", "2012", "2013", "2014" } }
            };

        // list some facts
        dynamic pepVsCocaColaFacts = dataAPI.GetFacts(token: token, dimensions: dimensions, labels: false);

        printFactTable(pepVsCocaColaFacts);
    }

    private static void attFacts(CellStore.Api.DataApi dataAPI, String token)
    {
      // list some facts
      dynamic ATandTFacts = dataAPI.GetFacts(token: token, ticker: new List<string> { "t" }, //AT&T ticker
                                                     fiscalYear: new List<string> { "2014", "2015" },
                                                     fiscalPeriod: new List<string> { "FY" },
                                                     concept: new List<string> { "us-gaap:Assets" });
      printFactTable(ATandTFacts);
    }

    private static void cocaColaFacts(CellStore.Api.DataApi dataAPI, String token)
    {
      // list some facts
      dynamic dow30Facts = dataAPI.GetFacts(token: token, ticker: new List<string> { "ko" }, //Coca-Cola ticker
                                                    concept: new List<string> { "us-gaap:Assets" },
                                                    labels: true,
                                                    fiscalPeriod: new List<string> { "FY" },
                                                    fiscalYear: new List<string> { "2014" },
                                                    dimensionSlicers: new Dictionary<string, bool?>
                                                    {
                                                      { "xbrl:Period::slicer", true },
                                                      //["xbrl:Period::slicer"] = true, Alternative syntax in C#6.0
                                                      { "xbrl28:Archive::slicer", true },
                                                      { "dei:LegalEntityAxis::slicer", true },
                                                      { "xbrl28:FiscalPeriod::slicer", true },
                                                      { "xbrl28:FiscalYear::slicer", true },
                                                      { "xbrl28:FiscalPeriodType::slicer", true}
                                                    },
                                                    dimensionColumns: new Dictionary<string, int?>
                                                    {
                                                      { "xbrl:Concept::column", 1 },
                                                      { "xbrl:Entity::column", 2},
                                                      { "xbrl:Unit::column", 3}
                                                    });
      printFactTable(dow30Facts);
    }

    private static void printFactTable(dynamic factsResponse)
    {
      dynamic factTable = factsResponse["FactTable"];
      int i = 0;
      foreach (dynamic fact in factTable)
      {
        Console.WriteLine("===========================");
        Console.WriteLine("Fact " + i + ":");
        Console.WriteLine(JsonConvert.SerializeObject(fact, Formatting.Indented));
        i++;
      }
      Console.WriteLine("Total: " + i);         
    }
  }
}