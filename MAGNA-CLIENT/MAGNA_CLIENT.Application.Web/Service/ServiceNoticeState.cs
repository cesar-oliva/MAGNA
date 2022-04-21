using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject.Notice;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceNoticeState : ICrudAsync<RegisterNoticeStateRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterNoticeStateRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterNoticeStateRequestDTO>> GetEntity(string nameService, string actionService)
        {

            List<RegisterNoticeStateRequestDTO> noticeStateList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                noticeStateList = JsonConvert.DeserializeObject<List<RegisterNoticeStateRequestDTO>>(resultString);
            }
            return noticeStateList;
        }

        public Task<RegisterNoticeStateRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, RegisterNoticeStateRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterNoticeStateRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}

