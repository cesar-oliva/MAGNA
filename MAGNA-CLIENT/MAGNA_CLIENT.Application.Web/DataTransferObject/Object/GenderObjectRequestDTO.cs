using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class GenderObjectRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string GenderDescription { get; set; }
        [Required]
        public bool GenderState { get; set; }
    }
}
