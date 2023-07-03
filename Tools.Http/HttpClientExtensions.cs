using System.Runtime.CompilerServices;

namespace Tools.Http
{
    public static class HttpClientExtensions
    {
        public static string Get(this HttpClient httpClient)
        {
            return httpClient.BaseAddress?.ToString() ?? "Null";
        }
    }
}