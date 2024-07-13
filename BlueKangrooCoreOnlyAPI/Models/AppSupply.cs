using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSupply
    {
        public Guid AppSupplyId { get; set; }
        public string AppSupplyName { get; set; }
        public string AppSupplyPercentage { get; set; }
        public string AppSupplyFromIndustryCode { get; set; }
        public decimal AppSupplyDeprivalRate { get; set; }
        public decimal AppSupplyAddOnRate { get; set; }
        public Guid AppProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
