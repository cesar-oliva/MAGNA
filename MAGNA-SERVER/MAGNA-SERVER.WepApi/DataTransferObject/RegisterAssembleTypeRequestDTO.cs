using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    [Table("AssembleType")]
    public class RegisterAssembleTypeRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string AssembleTypeCode { get; set; }
        [Required]
        public string AssembleTypeDescription { get; set; }
    }
}
