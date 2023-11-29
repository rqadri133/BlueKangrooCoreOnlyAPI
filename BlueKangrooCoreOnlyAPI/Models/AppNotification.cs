using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppNotification
    {
        public Guid AppNotificationId { get; set; }
        public string AppNotificationName { get; set; }
        public Guid AppNotificationSendNodeId { get; set; }
        public string AppNotificationMessageJson { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
