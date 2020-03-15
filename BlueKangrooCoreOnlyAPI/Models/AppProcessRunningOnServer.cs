using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProcessRunningOnServer
    {
        public Guid AppProcessRunningOnServerId { get; set; }
        public Guid AppProcessId { get; set; }
        public string AppProcessRunningOnServerName { get; set; }
        public string AppProcessRunningServerFileSystem { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
