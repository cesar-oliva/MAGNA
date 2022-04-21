using System;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class RegisterAssembleTypeRequestDTO
    {
        public Guid Id { get; set; }
        public string AssembleTypeCode { get; set; }
        public string AssembleTypeDescription { get; set; }
    }
}
