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
            String endpoint = "http://boi-poc.28.io/v1/_queries/public";
            CellStore.Client.ApiClient client = new CellStore.Client.ApiClient(endpoint);
            CellStore.Api.DataApi dataAPI = new CellStore.Api.DataApi(client);
            CellStore.Api.SessionsApi sessionsAPI = new CellStore.Api.SessionsApi(client);

            // login .. Alternative step to create a token dynamically
            //object loginResponse = sessionsAPI.Login("example@email.com", "password");
            //String token = loginResponse.token;
            //Console.WriteLine(login.token);
            String token = "foobar";

            // list some facts
            dynamic factsResonse = dataAPI.ListFacts(token, eid: "ALL", concept: "boi_met:mi1");
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
