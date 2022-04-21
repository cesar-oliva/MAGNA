using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject.Object
{
    public class RegisterNoticePriorityRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NoticePriorityCode { get; set; }
        [Required]
        public string NoticePriorityDescription { get; set; }
    }
}
