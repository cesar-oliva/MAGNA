using MAGNA_CLIENT.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Service
{
    public class ConnectionService : IConnectionService
    {
        public HttpClient CreateClientService(string nameService)
        {
            HttpClient clientHttp = new HttpClient();
            clientHttp.BaseAddress = new Uri(nameService);
            return clientHttp;
        }
    }
}
