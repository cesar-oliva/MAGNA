using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceNotice : ICrudAsync<RegisterNoticeRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public async Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.DeleteAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false; ;
        }

        public async Task<RegisterNoticeRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            RegisterNoticeRequestDTO notice = new RegisterNoticeRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                notice = JsonConvert.DeserializeObject<RegisterNoticeRequestDTO>(resultString);
                return notice;
            }
            return notice;
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

        public async Task<RegisterNoticeRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            RegisterNoticeRequestDTO notice = new RegisterNoticeRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                notice = JsonConvert.DeserializeObject<RegisterNoticeRequestDTO>(resultString);
                return notice;
            }
            return notice;
        }

        public async Task<bool> PostCreateEntity(string nameService, string actionService, RegisterNoticeRequestDTO Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.PostAsync(actionService, Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterNoticeRequestDTO Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.PutAsync(actionService + $"/{Entity.Id}", Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
