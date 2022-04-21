using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceAssembleType : ICrudAsync<RegisterAssembleTypeRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterAssembleTypeRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterAssembleTypeRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterAssembleTypeRequestDTO> typeList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                typeList = JsonConvert.DeserializeObject<List<RegisterAssembleTypeRequestDTO>>(resultString);
            }
            return typeList;
        }

        public Task<RegisterAssembleTypeRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, RegisterAssembleTypeRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterAssembleTypeRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
