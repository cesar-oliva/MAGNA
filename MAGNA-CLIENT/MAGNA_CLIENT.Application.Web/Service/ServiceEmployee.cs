using AutoMapper;
using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceEmployee : ICrudAsync<RegisterEmployeeRequestDTO>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public async Task<List<RegisterEmployeeRequestDTO>> GetEntity(string nameService, string actionService)
        {
            List<RegisterEmployeeRequestDTO> employeeDTOList = new();       
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                employeeDTOList = JsonConvert.DeserializeObject<List<RegisterEmployeeRequestDTO>>(resultString);

            }
            return employeeDTOList;
        }
        public async Task<bool> PostCreateEntity(string nameService, string actionService, RegisterEmployeeRequestDTO Entity)
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
        public async Task<RegisterEmployeeRequestDTO> GetUpdateEntity(string nameService, string actionService, Guid Id)
        {
            RegisterEmployeeRequestDTO employeeDTO = new RegisterEmployeeRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                employeeDTO = JsonConvert.DeserializeObject<RegisterEmployeeRequestDTO>(resultString);
                return employeeDTO;
            }
            return employeeDTO;
        }
        public async Task<bool> PutUpdateEntity(string nameService, string actionService, RegisterEmployeeRequestDTO Entity)
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
        public async Task<bool> GetDeleteEntity(string nameService, string actionService, Guid Id)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.DeleteAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<RegisterEmployeeRequestDTO> GetDetailEntity(string nameService, string actionService, Guid Id)
        {
            RegisterEmployeeRequestDTO employeeDTO = new RegisterEmployeeRequestDTO();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            clientHttp.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", ServiceAuthUser.GetToken()); //recupero el token y lo envio
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                employeeDTO = JsonConvert.DeserializeObject<RegisterEmployeeRequestDTO>(resultString);
                return employeeDTO;
            }
            return employeeDTO;
        }
    }
}
