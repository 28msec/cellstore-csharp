using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AddFacts
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
            //dynamic login = JsonConvert.DeserializeObject((String)loginResponse);
            //String token = login.token;
            //Console.WriteLine(login.token);
            String token = "c3049752-4d35-43da-82a2-f89f1b06f7a4";
            
            string factTxt = System.IO.File.ReadAllText(@"..\..\fact.json");
            Console.WriteLine("Fact = {0}", factTxt);
            dynamic fact = JsonConvert.DeserializeObject(factTxt);

            // add a fact
            dynamic addResonse = dataAPI.AddFacts(token, fact);
            Console.WriteLine("=============================");
            Console.WriteLine("Response:");
            Console.WriteLine(addResonse);
                
            Console.ReadKey();
        }
    }
}
