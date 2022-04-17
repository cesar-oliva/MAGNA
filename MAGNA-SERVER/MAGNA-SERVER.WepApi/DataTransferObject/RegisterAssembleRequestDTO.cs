using MAGNA_SERVER.Entities;
using System;
using System.Collections.Generic;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterAssembleRequestDTO
    {
        public Guid Id { get; set; }
        public string AssembleCode { get; set; }
        public string AssembleDescription { get; set; }
        public AssembleType AssembleType { get; set; }
    }
}



