using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppWareHouseNode
    {
        public Guid AppWareHouseNodeId { get; set; }
        public string AppWareHouseNodeName { get; set; }
        public Guid AppWareHouseVendorAttached { get; set; }
        public bool AppWareHouseNodeCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
