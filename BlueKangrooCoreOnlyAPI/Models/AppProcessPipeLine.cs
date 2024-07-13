using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProcessPipeLine
    {
        public Guid AppProcessPipleLineId { get; set; }
        public string AppProcessPipeLineName { get; set; }
        public Guid AppProcessPipeLinkActivityId { get; set; }
        public Guid AppProcessPipeLinkedEndId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
