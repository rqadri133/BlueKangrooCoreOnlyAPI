using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSupplyDemandChart
    {
        public Guid AppSupplyDemandId { get; set; }
        public string Quantity { get; set; }
        public decimal AppPriceExchanged { get; set; }
        public string AppGoodsExchanged { get; set; }
        public decimal AppSupplyDeprivalRate { get; set; }
        public decimal AppSupplyAddOnRate { get; set; }
        public string AppCureencyCode { get; set; }
        public Guid AppProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
