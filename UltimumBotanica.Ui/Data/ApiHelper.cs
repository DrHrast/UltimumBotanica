using System.Net.Http.Headers;

namespace UltimumBotanica.Ui.Data
{
    public class ApiHelper
    {
        private readonly string _apiEndpoint = "https://UltimumBotanica.Api";
        private HttpClient? _apiClient;
        public HttpClient ApiClient => _apiClient!;

        public ApiHelper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            _apiClient = new HttpClient
            {
                BaseAddress = new Uri(_apiEndpoint)
            };
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
