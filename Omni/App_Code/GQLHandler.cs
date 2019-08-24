using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;

namespace Omni.App_Code
{
    public static class GQLHandler
    {
        public static string token = "2ff449146b044b0628d8c38a96a1dcdb";
        public static string endpoint = "https://api.smash.gg/gql/alpha";
        public static string testNote = "";

        private static readonly HttpClient client = new HttpClient();

        public static async Task<dynamic> MakeRequest(GraphQLRequest gqlRequest)
        {
            var values = new Dictionary<string, string>
            {
                { "query", gqlRequest.query },
                {"variables", gqlRequest.variables }

            };
            var content = new FormUrlEncodedContent(values);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
   
            var response = await client.PostAsync(endpoint, content);

            var responseString = await response.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(responseString);
            return json;
            /*foreach (var obj in json.data.tournaments.nodes)
            {

                Tournament tourney = new Tournament(obj);
                string x = "";
            }*/
        }
    }
}