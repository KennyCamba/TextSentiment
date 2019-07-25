using App3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App3.Services
{
    class APIService
    {
        private const string urlBase = "https://southcentralus.api.cognitive.microsoft.com/text/analytics/v2.0";
        private const string suffix = "sentiment";

        public static async Task<Response> Post(Request model)
        {
            try
            {
                // C# to JSON
                var request = JsonConvert.SerializeObject(model);

                // Body
                var content = new StringContent(
                    request, Encoding.UTF8,
                    "application/json");

                var client = new HttpClient();

                // Request headers
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "675ea7995b684364bf0f49955edea61b");

                var url = urlBase + "/" + suffix;

                // Consumo de servicio
                var response = await client.PostAsync(url, content);

                // Leer el response
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                // JSON to C#
                return JsonConvert.DeserializeObject<Response>(result); ;
            }
            catch
            {
                return null;
            }
        }
    }
}
