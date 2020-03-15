using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTruckRoute
    {
        public Guid AppTruckRouteId { get; set; }
        public string AppTrouteDestinationNode { get; set; }
        public string AppTrouteManualIntersectionPointA { get; set; }
        public string AppTrouteManualIntersectionPointB { get; set; }
        public string AppTrouteManualIntersectionPointC { get; set; }
        public string AppTrouteManualIntersectionPointD { get; set; }
        public string AppTrouteSourceNode { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
