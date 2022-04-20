using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using MAGNA_CLIENT.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceGender : ICrudAsync<QueryGenderRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<QueryGenderRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            QueryGenderRequestDTO genderDTO = new QueryGenderRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUserDTO.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                genderDTO = JsonConvert.DeserializeObject<QueryGenderRequestDTO>(resultString);
                return genderDTO;
            }
            return genderDTO;
        }

        public async Task<List<QueryGenderRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<QueryGenderRequestDTO> genderList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                genderList = JsonConvert.DeserializeObject<List<QueryGenderRequestDTO>>(resultString);
            }
            return genderList;
        }

        public Task<QueryGenderRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, QueryGenderRequestDTO Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, QueryGenderRequestDTO Entity)
        {
            throw new NotImplementedException();
        }
    }
}
