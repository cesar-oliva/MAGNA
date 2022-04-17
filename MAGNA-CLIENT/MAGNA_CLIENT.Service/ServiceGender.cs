using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Service
{
    public class ServiceGender: ICrudAsync<Gender>
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public Task<bool> GetDeleteEntity(string nameService, string actionService, int? Id)
        {
            throw new NotImplementedException();
        }

        public Task<Gender> GetDetailEntity(string nameService, string actionService, int? Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Gender>> GetEntity(string nameService, string actionService)
        {
            List<Gender> genderList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                genderList = JsonConvert.DeserializeObject<List<Gender>>(resultString);
            }
            return genderList;
        }

        public Task<Gender> GetUpdateEntity(string nameService, string actionService, int? Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PostCreateEntity(string nameService, string actionService, Gender Entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PutUpdateEntity(string nameService, string actionService, Gender Entity)
        {
            throw new NotImplementedException();
        }
    }
}

