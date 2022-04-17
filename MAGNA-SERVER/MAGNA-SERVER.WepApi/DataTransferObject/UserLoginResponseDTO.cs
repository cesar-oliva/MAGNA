using System.Collections.Generic;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class UserLoginResponseDTO
    {
        public string Token { get; set; }
        public bool Login { get; set; }
        public List<string> Errors { get; set; }    
    }
}
