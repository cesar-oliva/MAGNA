using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    /// <summary>
    /// represents the request by the client for user registration
    /// </summary>
    public class RegisterUserRequestDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public List<string> Roles { get; set; }

    }
}
