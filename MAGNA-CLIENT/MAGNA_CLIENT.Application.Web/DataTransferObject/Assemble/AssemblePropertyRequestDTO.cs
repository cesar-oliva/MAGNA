using System;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject.Assemble
{
    public class AssemblePropertyRequestDTO
    {
        public Guid AssemblePropertyId { get; set; }
        public string AssembleMaker { get; set; }
        public string AssembleSerialNumber { get; set; }
        public string AssemblePurchaseDate { get; set; }
        public string AssembleDayGuarantee { get; set; }
    }
}
