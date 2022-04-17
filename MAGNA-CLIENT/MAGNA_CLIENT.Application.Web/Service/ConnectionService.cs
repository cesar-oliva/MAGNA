using MAGNA_CLIENT.Abstractions;
using System;
using System.Net.Http;

namespace MAGNA_CLIENT.Application.Web.Service
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
