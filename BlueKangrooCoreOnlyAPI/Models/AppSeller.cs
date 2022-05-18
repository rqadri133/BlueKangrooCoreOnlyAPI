using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppSeller
    {
        public Guid AppSellerId { get; set; }
        public string AppSellerName { get; set; }
        public string AppSellerLicenseHashedId { get; set; }
        public string AppSellerHashedSsc { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
         
        public bool EthereumAcceptable {get;set;}  

    }
}
