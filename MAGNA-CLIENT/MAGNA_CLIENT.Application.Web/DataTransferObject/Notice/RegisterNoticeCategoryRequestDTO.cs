using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
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
