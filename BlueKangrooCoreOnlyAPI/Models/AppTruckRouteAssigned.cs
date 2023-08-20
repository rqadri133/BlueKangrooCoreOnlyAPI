using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTruckRouteAssigned
    {
        public Guid AppTruckRouteAssignedId { get; set; }
        public Guid AppTruckId { get; set; }
        public Guid AppTruckRouteId { get; set; }
        public string AppTrouteDestinationNode { get; set; }
        public string AppTrouteSourceNode { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
