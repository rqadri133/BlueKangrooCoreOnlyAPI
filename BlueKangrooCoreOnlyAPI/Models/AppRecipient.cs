using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppRecipient
    {
        public Guid AppRecipientId { get; set; }
        public string AppRecipientName { get; set; }
        public string AppRecipientAddress { get; set; }
        public string AppRecipientCity { get; set; }
        public string AppRecipientStateProvinceCode { get; set; }
        public string AppRecipientCountryCode { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
