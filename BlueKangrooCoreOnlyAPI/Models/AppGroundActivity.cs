using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppGroundActivity
    {
        public Guid AppGroundActivityId { get; set; }
        public Guid AppGroundLogisticsId { get; set; }
        public string SourceLocation { get; set; }
        public string DestinationLocation { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
