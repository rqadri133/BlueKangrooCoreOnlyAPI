using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppBuyerCostSheet

    {
        public Guid AppBuyerCostId { get; set; }
        public string AppBuyerId { get; set; }
        public string AppProductId { get; set; }
        public decimal? AppItemCost { get; set; }
        public Guid AppDutyIdapplied { get; set; }
        public decimal? AppShipmentCost { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
