using Tools.Http;

namespace Models
{
    public class FakeService : IRepository
    {
        private readonly HttpClient _httpClient;

        public FakeService(IHttpClientBuilder httpClientBuilder)
        {
            _httpClient = httpClientBuilder.CreateClient("api");
        }

        public string Get()
        {
            return _httpClient.Get();
        }
    }
}