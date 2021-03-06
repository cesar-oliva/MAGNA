using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAGNA_CLIENT.Entities
{
    public class Employee:Entity
    {
        public Guid Id { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public Gender Gender { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeCountry { get; set; }
        public string EmployeeCity { get; set; }
        public string EmployeeEmailAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public DateTime EmployeeBirthday { get; set; }
        public string EmployeePhotoUrl { get; set; }
        public DateTime EmployeeStartDate { get; set; }
        public DateTime? EmployeeEndDate { get; set; }
        public int EmployeeState { get; set; }
    }
}
