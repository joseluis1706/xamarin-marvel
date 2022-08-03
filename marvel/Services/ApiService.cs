using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace marvel.Services
{
    public class ApiService : IApiService
    {
        public async Task<T> GetAsync<T>(string url, string endpoint)
        {
            try
            {
                string fullUrl = $"{url}{endpoint}";

                HttpClient httpClient = new HttpClient();

                HttpResponseMessage response = await httpClient.GetAsync(fullUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();

                    T deserializeResponse = JsonConvert.DeserializeObject<T>(json);

                    return deserializeResponse;
                }

                throw new Exception("Hubo un error al consultar la informacion");
            }
            catch
            {
                throw new Exception("Hubo un error al consultar la informacion");
            }
        }
    }
}
