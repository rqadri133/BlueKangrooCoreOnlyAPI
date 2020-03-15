using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppPriceParityCheck
    {
        public Guid AppPriceParityCheckId { get; set; }
        public string AppPriceParityCheckReason { get; set; }
        public decimal DeductionApplied { get; set; }
        public Guid AppProductId { get; set; }
        public Guid AppSellerOne { get; set; }
        public Guid AppSellerTwo { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
