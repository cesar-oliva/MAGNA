using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Abstractions
{
    public interface IConnectionService
    {
        HttpClient CreateClientService(string nameService);
    }
}
