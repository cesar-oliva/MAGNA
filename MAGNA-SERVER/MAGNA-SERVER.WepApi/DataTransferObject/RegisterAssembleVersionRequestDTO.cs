namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterAssembleVersionRequestDTO
    {
        public string AssembleVersionCode { get; set; }
        public string AssembleVersionDescription { get; set; }
        public int AssembleVersionNumber { get; set; }
        public string AssembleLocation { get; set; }
        public string AssembleMaker { get; set; }
        public string AssemblePurchaseDate { get; set; }
        public string AssembleSerialNumber { get; set; }
        public int AssembleDayGuarantee { get; set; }
    }
}
