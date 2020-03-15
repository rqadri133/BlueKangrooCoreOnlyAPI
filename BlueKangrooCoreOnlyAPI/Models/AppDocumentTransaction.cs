using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppDocumentTransaction
    {
        public Guid AppDocumentTransactionId { get; set; }
        public string AppDocumentTemplatePath { get; set; }
        public string AppDocumentText { get; set; }
        public decimal AppDocumentAmount { get; set; }
        public byte[] AppDocumentSignature { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
