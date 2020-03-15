using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppCrossRefProcess
    {
        public Guid AppCrossRefProcessId { get; set; }
        public Guid ProcessSourceId { get; set; }
        public Guid NextSubProcessId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
