using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDispatchAssigned
    {
        public Guid AppDispatchAssignedId { get; set; }
        public Guid AppDispatchRefId { get; set; }
        public Guid AppProductId { get; set; }
        public Guid AppSenderId { get; set; }
        public Guid AppRecipientId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
