using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppMetalCombinationAlloy
    {
        public Guid AppMetalCombinationAlloyId { get; set; }
        public Guid AppMetalCombinationAlloyName { get; set; }
        public string AppAtSeparatedMetalPeriodicTableId { get; set; }
        public decimal MaximumHeatingAppliedTemp { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
