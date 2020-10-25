using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using RestSharp;

namespace Omni.App_Code
{
    public class GraphQL
    {

        private static string token = "adabbbee6af9f9533087fe2361eb9475";
        private static string endPoint = "https://api.smash.gg/gql/alpha";

        public static string makeRequest(string queryString, string vars)
        {
            var client = new RestClient(endPoint);
            var request = new RestRequest(Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddJsonBody(new 
            { 
                query = queryString,
                variables = vars
            });

            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}