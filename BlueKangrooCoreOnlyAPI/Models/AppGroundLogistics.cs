using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppGroundLogistics
    {
        public Guid AppGroundLogisticId { get; set; }
        public string AppGroundLogisticsName { get; set; }
        public string AppGroundSourceAddress { get; set; }
        public string AppGroundLogisticsInternalOrExternal { get; set; }
        public string AppGroundLogisticsDesc { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public string AppGroundSourceZipCode { get; set; }
    }
}
