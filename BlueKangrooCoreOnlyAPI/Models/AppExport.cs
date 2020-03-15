using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppExport
    {
        public Guid AppExportId { get; set; }
        public Guid AppSellerId { get; set; }
        public Guid AppBuyerId { get; set; }
        public Guid AppTradeFinanceCompanyId { get; set; }
        public Guid AppDutyId { get; set; }
        public Guid ProductId { get; set; }
        public string ExportDescriptionNotes { get; set; }
        public bool LetterOfCreditApproved { get; set; }
        public decimal ExportLifeCycleCostTotal { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
