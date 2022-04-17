using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class UserLoginRequestDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
