using MAGNA_SERVER.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    [Table("Employee")]
    public class RegisterEmployeeRequestDTO
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("File number assigned to the employee")]
        public string EmployeeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeFirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeLastName { get; set; }
        [Required]
        [StringLength(150)]
        public string EmployeeAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCountry { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeCity { get; set; }
        [Required]
        [StringLength(100)]
        public string EmployeeEmailAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeePhoneNumber { get; set; }
        [Required]
        public DateTime EmployeeBirthday { get; set; }
        //[Required]
        public string EmployeePhotoUrl { get; set; }
        [Required]
        public DateTime EmployeeStartDate { get; set; }
        public DateTime? EmployeeEndDate { get; set; }
        [Required]
        public int EmployeeState { get; set; }
        [Required]
        public Guid GenderId { get; set; }
    }
}

