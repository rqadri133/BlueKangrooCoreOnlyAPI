using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDocumentAssigned
    {
        public Guid BusineesDocAssignedId { get; set; }
        public Guid BusinessDocUserId { get; set; }
        public Guid ActivityAssignedId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
