using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
        public partial class AppBuyer
        {
            public Guid AppBuyerId { get; set; }
            public string AppBuyerName { get; set; }
            public string AppBuyerLicenseHashedId { get; set; }
            public string AppBuyerHashedSsc { get; set; }
            public DateTime CreatedDate { get; set; }
            public Guid CreatedBy { get; set; }
        }
}
