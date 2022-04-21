using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceNotice : ICrudAsync<RegisterNoticeRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterNoticeRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RegisterNoticeRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterNoticeRequestDTO> noticeDTOList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                noticeDTOList = JsonConvert.DeserializeObject<List<RegisterNoticeRequestDTO>>(resultString);

            }
            return noticeDTOList;
        }

        public Task<RegisterNoticeRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, RegisterNoticeRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterNoticeRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
