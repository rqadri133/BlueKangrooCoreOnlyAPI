using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDispatch
    {
        public Guid AppDispatchId { get; set; }
        public Guid AppSender { get; set; }
        public string AppDispatchNameDecs { get; set; }
        public Guid AppRecipientId { get; set; }
        public Guid ItemCombinationListId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
