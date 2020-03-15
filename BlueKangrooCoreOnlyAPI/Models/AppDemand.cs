using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDemand
    {
        public Guid AppDemandId { get; set; }
        public string AppDemandName { get; set; }
        public string AppDemandPercentage { get; set; }
        public string AppDemandFromPopulationCode { get; set; }
        public decimal AppDemandDeprivalRate { get; set; }
        public decimal AppDemandIncreaseRate { get; set; }
        public Guid AppProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
