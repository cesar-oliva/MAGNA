using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject.Object
{
    public class RegisterTechnicalLocationRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string GenderDescription { get; set; }
    }
}
