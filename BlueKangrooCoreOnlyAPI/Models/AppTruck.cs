using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppTruck
    {
        public Guid AppTruckId { get; set; }
        public string AppTruckVehicleIdnVin { get; set; }
        public string AppTruckColorModelDecs { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
