using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppOrder
    {
        public Guid AppOrderId { get; set; }
        public Guid AppProductId { get; set; }
        public int Quantity { get; set; }
        public string AppOrderDesc { get; set; }
        public DateTime AppOrderDate { get; set; }
        public string AppOrderPersonName { get; set; }
        public string AppOrderShippingStreetAddress { get; set; }
        public string AppOrderZipCode { get; set; }
        public string AppOrderCountryCode { get; set; }
        public string AppOrderStateCode { get; set; }
        public int AppOrderStatus { get; set; }
        public decimal AppOrderAmountTotal { get; set; }
        public decimal AppOrderRefundTotal { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
