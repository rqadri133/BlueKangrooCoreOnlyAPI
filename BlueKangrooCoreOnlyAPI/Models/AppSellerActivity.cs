using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSellerActivity
    {
        public Guid AppSellerActivityId { get; set; }
        public Guid AppSellerId { get; set; }
        public Guid AppActivityId { get; set; }
        public string AppSellerActivityDesc { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
