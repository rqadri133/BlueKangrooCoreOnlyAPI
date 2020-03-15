using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppActivity
    {
        public Guid AppActivityId { get; set; }
        public string AppActivityName { get; set; }
        public DateTime AppActivityStartDate { get; set; }
        public Guid AppProjectId { get; set; }
        public DateTime AppActivityEndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
