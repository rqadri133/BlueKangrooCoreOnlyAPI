using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppRoute
    {
        public Guid AppRouteId { get; set; }
        public string AppRouteDesc { get; set; }
        public string AppLocationStartId { get; set; }
        public string AppLocationEndId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
