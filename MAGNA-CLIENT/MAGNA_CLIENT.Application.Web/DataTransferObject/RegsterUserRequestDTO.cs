using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class RegsterUserRequestDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
