using System;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterNoticeCategoryRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string NoticeCategoryCode { get; set; }
        [Required]
        public string NoticeCategoryDescription { get; set; }
    }
}
