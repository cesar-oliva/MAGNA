using System.Collections.Generic;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class AssembleResponseDTO
    {
        public bool result { get; set; }
        public List<string> Errors { get; set; }
    }   
}
