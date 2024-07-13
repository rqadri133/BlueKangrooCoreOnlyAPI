using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class Appcart
    {
        public Guid Appcartid { get; set; }
        public string Appcartdesc { get; set; }
        public Guid AppOrderdetailsId { get; set; }
        public bool IsPaymentApplied { get; set; }
        public Guid PaymentHistoryId { get; set; }
        public DateTime Createddate { get; set; }
        public Guid Createdby { get; set; }
    }
}
