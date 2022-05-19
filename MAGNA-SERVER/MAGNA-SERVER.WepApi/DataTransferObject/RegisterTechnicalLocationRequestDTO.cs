using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterTechnicalLocationRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string TechnicalLocationCode { get; set; }
        [Required]
        public string TechnicalLocationDescription { get; set; }
    }
}
