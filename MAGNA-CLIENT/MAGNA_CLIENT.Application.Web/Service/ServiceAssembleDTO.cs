using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;


namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceAssembleDTO : ICrudAsync<RegisterAssembleRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public async Task<List<RegisterAssembleRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterAssembleRequestDTO> assembleList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                assembleList = JsonConvert.DeserializeObject<List<RegisterAssembleRequestDTO>>(resultString);
            }
            return assembleList;
        }
        public async Task<bool> PostCreateEntity(string nameService, string actionService, RegisterAssembleRequestDTO Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PostAsync(actionService, Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<RegisterAssembleRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            RegisterAssembleRequestDTO assemble = new RegisterAssembleRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                assemble = JsonConvert.DeserializeObject<RegisterAssembleRequestDTO>(resultString);
                return assemble;
            }
            return assemble;
        }
        public async Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterAssembleRequestDTO Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PutAsync(actionService + $"/{Entity.Id}", Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.DeleteAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<RegisterAssembleRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            RegisterAssembleRequestDTO assemble = new RegisterAssembleRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                assemble = JsonConvert.DeserializeObject<RegisterAssembleRequestDTO>(resultString);
                return assemble;
            }
            return assemble;
        }
    }
}
