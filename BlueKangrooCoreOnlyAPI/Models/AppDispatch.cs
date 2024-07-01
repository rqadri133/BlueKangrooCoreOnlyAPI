using System;
using System.Buffers;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDispatch
    {
        public Guid AppDispatchId { get; set; }
        public string AppDipatchDetailsDesc { get; set; }
        public string ItemCombinationJson {get;set;}
        public Guid AppSenderId {get;set;}
        public Guid AppLocationId { get; set; }
        public Guid AppPackageId { get; set; }
        public Guid AppPackageHandlerId { get; set; }
        public Guid AppCartId { get; set; }
        public DateTime AppScheduledDispatchDate { get; set; }
        public DateTime AppEstimatedDeliveryDate { get; set; }
        public DateTime AppActualDeliveryDate { get; set; }
        public DateTime AppActualDipatchDate { get; set; }
        public bool RecallDispatched { get; set; }
        public DateTime RecallCancelDispatchedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
