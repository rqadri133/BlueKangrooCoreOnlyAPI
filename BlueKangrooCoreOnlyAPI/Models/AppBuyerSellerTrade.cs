using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppBuyerSellerTrade
    {
        public Guid AppTradeId { get; set; }
        public Guid AppBuyerId { get; set; }
        public Guid AppUserId { get; set; }
        public Guid AppSellerId { get; set; }
        public Guid AppTransactionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
