using MAGNA_CLIENT.Abstractions;
using MAGNA_CLIENT.Application.Web.DataTransferObject;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Application.Web.Service
{
    public class ServiceAuthUser 
    {
        private readonly IConnectionService _httpClientFactory = new ConnectionService();
        static string _token = string.Empty;   

        public async Task<UserLoginResponseDTO> LoginUser(string nameService, string actionService, UserLoginRequestDTO Entity)
        {
            var clientHttp = _httpClientFactory.CreateClientService(nameService);
            var request = await clientHttp.PostAsync(actionService, Entity, new JsonMediaTypeFormatter());

            if(request.IsSuccessStatusCode)
            {
                var resultString = await request.Content.ReadAsStringAsync();
                var userDTO = JsonConvert.DeserializeObject<UserLoginResponseDTO>(resultString);
                _token = userDTO.Token;
                return userDTO;
            }

            return new UserLoginResponseDTO();
        }
        public static string GetToken()
        {
            return _token;
        }
    }
}
