using BlueKangrooCoreOnlyAPI.Mapper;
using System;
using RestSharp;
using Rest.Configuration;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Headers
{
    public class BearerToken
    {
        public static Token GetToken(string url , ClientCredentials credentials )
        {
            Token token = new Token();
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", JsonSerializer.Serialize(credentials), ParameterType.RequestBody);
            var response  = client.Execute(request);
            if(response != null)
            {
                token = JsonSerializer.Deserialize<Token>(response.Content);
            }

            return token;
        }


    }
}
