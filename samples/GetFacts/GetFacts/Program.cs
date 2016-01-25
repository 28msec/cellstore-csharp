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
            CellStore.Client.ApiClient client = new CellStore.Client.ApiClient(endpoint);
            CellStore.Api.DataApi dataAPI = new CellStore.Api.DataApi(client);
            CellStore.Api.SessionsApi sessionsAPI = new CellStore.Api.SessionsApi(client);

            // login .. Alternative step to create a token dynamically
            //object loginResponse = sessionsAPI.Login("example@email.com", "password");
            //String token = loginResponse.token;
            //Console.WriteLine(login.token);
            String token = "c3049752-4d35-43da-82a2-f89f1b06f7a4";

            // list some facts
            dynamic factsResonse = dataAPI.ListFacts(token, ticker: "t", fiscalYear: "2014", fiscalPeriod: "FY", concept: "us-gaap:Assets");
            dynamic factTable = factsResonse["FactTable"];
            int i = 0;
            foreach (dynamic fact in factTable.Children())
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Fact " + i + ":");
                Console.WriteLine(JsonConvert.SerializeObject(fact, Formatting.Indented));
                i++;
            }

            //Console.ReadKey();
        }
    }
}
