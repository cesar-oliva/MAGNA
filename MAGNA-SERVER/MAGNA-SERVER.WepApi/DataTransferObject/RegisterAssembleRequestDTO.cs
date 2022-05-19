﻿using MAGNA_SERVER.Entities;
using System;
using System.Collections.Generic;

namespace MAGNA_SERVER.WebApi.DataTransferObject
{
    public class RegisterAssembleRequestDTO
    {
        public Guid Id { get; set; }
        public string AssembleCode { get; set; }
        public string AssembleDescription { get; set; }
        public Guid AssembleTypeId { get; set; }
        public Guid TechnicalLocationId { get; set; }
        public string AssembleMaker { get; set; }
        public string AssembleSerialNumber { get; set; }
        public string AssemblePurchaseDate { get; set; }
        public string AssembleMonthsGuarantee { get; set; }

    }
}







