using System.ComponentModel.DataAnnotations;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class UserLoginRequestDTO
    {
        [Required]
        public string Username{ get; set; }
        [Required]
        public string Password{ get; set; }
    }
}
