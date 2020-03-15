using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProduct
    {
        public Guid AppProductId { get; set; }
        public string AppProductName { get; set; }
        public decimal AppProductPerUnitPrice { get; set; }
        public Guid AppInsuredByCompany { get; set; }
        public int AppProductAvailableInStocks { get; set; }
        public string AppProductBarCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
