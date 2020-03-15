using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppGroundLifter
    {
        public Guid AppForkLifterId { get; set; }
        public string AppForkLifterName { get; set; }
        public string AppForkLifterColor { get; set; }
        public string Model { get; set; }
        public string Vinnumber { get; set; }
        public decimal AppForkLifterMaxWeightCapacity { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
