using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppBuyerActivity
    {
        public Guid AppBuyerActivityId { get; set; }
        public Guid AppBuyerId { get; set; }
        public Guid AppActivityId { get; set; }
        public string AppBuyerActivityDesc { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
