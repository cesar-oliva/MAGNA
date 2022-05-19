using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Object;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceTechnicalLocation : ICrudAsync<RegisterTechnicalLocationRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterTechnicalLocationRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterTechnicalLocationRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterTechnicalLocationRequestDTO> technicalLocationList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                technicalLocationList = JsonConvert.DeserializeObject<List<RegisterTechnicalLocationRequestDTO>>(resultString);
            }
            return technicalLocationList;
        }

        public Task<RegisterTechnicalLocationRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, RegisterTechnicalLocationRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterTechnicalLocationRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
