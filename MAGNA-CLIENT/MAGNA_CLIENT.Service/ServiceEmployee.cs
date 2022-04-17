using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Service
{
    public class ServiceEmployee : ICrudAsync<Employee>
    {
         private readonly IConnectionService _httpClientFactory = new ConnectionService();

        public async Task<List<Employee>> GetEntity(string nameService, string actionService)
        {
            List<Employee> employeeList = new();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService);
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService);
                employeeList = JsonConvert.DeserializeObject<List<Employee>>(resultString);
            }
            return employeeList;
        }
        public async Task<bool> PostCreateEntity(string nameService, string actionService, Employee Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PostAsync(actionService, Entity, new JsonMediaTypeFormatter());
            
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<Employee> GetUpdateEntity(string nameService, string actionService, int? Id)
        {
            Employee employee = new Employee();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                employee = JsonConvert.DeserializeObject<Employee>(resultString);
                return employee;
            }
            return employee;
        }
        public async Task<bool> PutUpdateEntity(string nameService, string actionService, Employee Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PutAsync(actionService + $"/{Entity.Id}", Entity, new JsonMediaTypeFormatter());
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> GetDeleteEntity(string nameService, string actionService, int? Id)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.DeleteAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<Employee> GetDetailEntity(string nameService, string actionService, int? Id)
        {
            Employee employee = new Employee();
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.GetAsync(actionService + $"/{Id}");
            if (request.IsSuccessStatusCode)
            {
                var resultString = await clientHttp.GetStringAsync(actionService + $"/{Id}");
                employee = JsonConvert.DeserializeObject<Employee>(resultString);
                return employee;
            }
            return employee;
        }
    }
}
