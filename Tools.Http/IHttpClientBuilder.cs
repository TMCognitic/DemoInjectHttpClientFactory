using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Http
{
    public interface IHttpClientBuilder
    {
        HttpClient CreateClient();
        HttpClient CreateClient(string name);
    }
}
