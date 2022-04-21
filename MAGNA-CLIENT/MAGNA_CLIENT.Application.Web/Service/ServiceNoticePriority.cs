using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Object;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceNoticePriority : ICrudAsync<RegisterNoticePriorityRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();
        
        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterNoticePriorityRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterNoticePriorityRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterNoticePriorityRequestDTO> noticePriorityList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                noticePriorityList = JsonConvert.DeserializeObject<List<RegisterNoticePriorityRequestDTO>>(resultString);
            }
            return noticePriorityList;
        }

        public Task<RegisterNoticePriorityRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, RegisterNoticePriorityRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterNoticePriorityRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
