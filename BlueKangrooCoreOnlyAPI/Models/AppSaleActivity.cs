using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSaleActivity
    {
        public Guid AppSaleActivityId { get; set; }
        public string AppSaleDesc { get; set; }
        public Guid AppActivityId { get; set; }
        public Guid SalePersonId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
