using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProcess
    {
        public Guid AppProcessId { get; set; }
        public string AppProcessName { get; set; }
        public string AppProcessMode { get; set; }
        public string AppProcessDesc { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
