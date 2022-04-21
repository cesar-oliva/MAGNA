using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceNoticeCategory : ICrudAsync<RegisterNoticeCategoryRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterNoticeCategoryRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterNoticeCategoryRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterNoticeCategoryRequestDTO> noticeCategoryList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                noticeCategoryList = JsonConvert.DeserializeObject<List<RegisterNoticeCategoryRequestDTO>>(resultString);
            }
            return noticeCategoryList;
        }

        public Task<RegisterNoticeCategoryRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, RegisterNoticeCategoryRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterNoticeCategoryRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
