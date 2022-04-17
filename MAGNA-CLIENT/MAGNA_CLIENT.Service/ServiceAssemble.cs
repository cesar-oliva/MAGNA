using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Service
{
    public class ServiceAssemble : ICrudAsync<Assemble>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public async Task<List<Assemble>> GetEntity(string nameService, string actionService)
        {
            List<Assemble> assembleList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                assembleList = JsonConvert.DeserializeObject<List<Assemble>>(resultString);
            }
            return assembleList;
        }
        public async Task<bool> PostCreateEntity(string nameService, string actionService, Assemble Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PostAsync(actionService,Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<Assemble> GetUpdateEntity(string nameService, string actionService, int? Id)
        {
            Assemble assemble = new Assemble();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                assemble = JsonConvert.DeserializeObject<Assemble>(resultString);
                return assemble;
            }
            return assemble;
        }
        public async Task<bool> PutUpdateEntity(string nameService, string actionService, Assemble Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PutAsync(actionService + $"/{Entity.Id}", Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> GetDeleteEntity(string nameService, string actionService, int? Id)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.DeleteAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<Assemble> GetDetailEntity(string nameService, string actionService, int? Id)
        {
            Assemble assemble = new Assemble();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                assemble = JsonConvert.DeserializeObject<Assemble>(resultString);
                return assemble;
            }
            return assemble;
        }
    }
}
