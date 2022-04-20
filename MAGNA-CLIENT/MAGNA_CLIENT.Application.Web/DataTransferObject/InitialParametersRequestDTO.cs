using System;
using System.Collections.Generic;

namespace MAGNA_CLIENT.Application.Web.DataTransferObject
{
    public class InitialParametersRequestDTO
    {
        public List<GenderDTO> GenderDTOList { get; set; }
        public List<NoticeCategoryDTO> NoticeCategoryList { get; set; }
        public List<NoticePriorityDTO> NoticePriorityList { get; set; }
    }

    public class GenderDTO
    { 
        public Guid Id { get; set; }
        public string GenderDescription { get; set; }
    }
    public class NoticeCategoryDTO
    {
        public Guid Id { get; set; }
        public string NoticeCategoryDescription { get; set; }
    }
    public class NoticePriorityDTO
    {
        public Guid Id { get; set; }
        public string NoticePriorityDescription { get; set; }
    }
}
