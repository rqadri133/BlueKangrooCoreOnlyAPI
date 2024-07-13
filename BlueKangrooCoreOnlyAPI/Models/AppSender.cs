using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSender
    {
        public Guid AppSenderId { get; set; }
        public string AppSenderName { get; set; }
        public string AppSenderStreetAddress { get; set; }
        public string AppSenderZipCode { get; set; }
        public string AppSenderContactPhone { get; set; }
        public string AppSenderCity { get; set; }
        public string AppSenderCountry { get; set; }
        public bool IsSenderIsCompany { get; set; }
        public string SenderInstructionsNotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
