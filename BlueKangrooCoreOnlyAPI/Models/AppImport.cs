using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppImport
    {
        public Guid AppImportId { get; set; }
        public Guid AppSellerId { get; set; }
        public Guid AppBuyerId { get; set; }
        public Guid AppTradeFinanceCompanyId { get; set; }
        public Guid AppDutyId { get; set; }
        public Guid ProductId { get; set; }
        public string ImportDescriptionNotes { get; set; }
        public bool LetterOfCreditApproved { get; set; }
        public decimal ImportLifeCycleCostTotal { get; set; }
        public decimal ImportDeprecatedCostCycle { get; set; }
        public decimal ImportDamagedInsuranceCost { get; set; }
        public DateTime ContractNonArrivalExpirationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
