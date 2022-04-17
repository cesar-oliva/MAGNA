using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class GenderRequestDTO
    {
        [Required]
        [Key]
        public Guid GenderId { get; set; }
        [StringLength(50)]
        public string GenderDescription { get; set; }
        [Required]
        [StringLength(50)]
        public bool GenderState { get; set; }

        public List<RegisterEmployeeRequestDTO> EmployeeDTO { get; set; }
    }
}
