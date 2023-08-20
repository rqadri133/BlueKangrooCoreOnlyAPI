using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppGroundLogistic
    {
        public Guid AppGroundLogisticId { get; set; }
        public string AppGroundLogisticsName { get; set; }
        public string AppGroundSourceAddress { get; set; }
        public string AppGroundLogisticsInternalOrExternal { get; set; }
        public string AppGroundLogisticsDesc { get; set; }

        public string AppGroundLogisticZipCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
