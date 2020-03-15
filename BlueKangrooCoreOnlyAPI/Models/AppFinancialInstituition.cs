using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppFinancialInstituition
    {
        public Guid AppFinancialInstituitionId { get; set; }
        public string AppFinancialInstituitionName { get; set; }
        public string AppFhidapproved { get; set; }
        public string AppCountryCode { get; set; }
        public Guid AppDocumentTransactionId { get; set; }
        public string AppStateCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
