using System;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterAssemblePropertyRequestDTO
    {
        public Guid AssemblePropertyId { get; set; }
        public string AssembleMaker { get; set; }
        public string AssembleSerialNumber { get; set; }
        public string AssemblePurchaseDate { get; set; }
        public string AssembleDayGuarantee { get; set; }
    }
}
