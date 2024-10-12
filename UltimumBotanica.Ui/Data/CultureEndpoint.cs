using UltimumBotanica.Ui.Models;
using Microsoft.Extensions.Http;

namespace UltimumBotanica.Ui.Data
{
    public class CultureEndpoint
    {
        private readonly ApiHelper _apiHelper;

        public CultureEndpoint(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        } 

        public async Task<List<string>> GetAllCultureNames()
        {
            using var response = await _apiHelper.ApiClient.GetAsync("/api/Culture/GetAllCultureNames");

            if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);

            var result = await response.Content.ReadAsAsync<List<string>>();
            return result;
        }
    }
}
