using Tools.Http;

namespace DemoInjectHttpClientFactory.Infractructure
{
    public class HttpClientBuilder : Tools.Http.IHttpClientBuilder
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpClientBuilder(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public HttpClient CreateClient()
        {
            throw new NotImplementedException();
        }

        public HttpClient CreateClient(string name)
        {
            return _httpClientFactory.CreateClient(name);
        }
    }
}
