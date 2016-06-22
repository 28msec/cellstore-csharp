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
        String endpointBoi = "http://boi-demo.28.io/v1/_queries/public";

        CellStore.Client.ApiClient client = new CellStore.Client.ApiClient(endpointBoi);
        CellStore.Client.Configuration clientCon = new CellStore.Client.Configuration(client);
        CellStore.Api.DataApi dataAPI = new CellStore.Api.DataApi(clientCon);

        String token = "foobar";

        Object result = dataAPI.GetRules(
            token: token,
            aid: new List<string> {"12001_90_16__20140630"}
        );

    }
  }
}
