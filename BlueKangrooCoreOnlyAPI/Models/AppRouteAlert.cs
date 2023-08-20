using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppRouteAlert
    {
        public Guid AppRouteAlertId { get; set; }
        public string AppRouteAlertDesc { get; set; }
        public string AppRouteId { get; set; }
        public string AppRouteAlertEvent { get; set; }
        public string AppRouteChangeNotification { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
