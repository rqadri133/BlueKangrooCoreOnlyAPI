using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppWareHouseVendor
    {
        public Guid AppWareHouseVendorId { get; set; }
        public string AppWareHouseVendorName { get; set; }
        public Guid AppWareHouseVendorDesc { get; set; }
        public string AppWareHouseMaterialExpert { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
