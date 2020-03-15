using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppFactor
    {
        public Guid AppFactorId { get; set; }
        public string AppFactorName { get; set; }
        public decimal AppFactorValue { get; set; }
        public Guid AppFactorRelatedtoId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
