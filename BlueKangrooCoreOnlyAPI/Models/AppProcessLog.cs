using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProcessLog
    {
        public Guid AppProcessLogId { get; set; }
        public string AppProcessId { get; set; }
        public string AppProcessLogInformation { get; set; }
        public string AppProcessLogDumpings { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
