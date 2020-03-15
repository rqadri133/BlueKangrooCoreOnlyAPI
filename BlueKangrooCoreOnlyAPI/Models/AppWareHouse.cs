using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppWareHouse
    {
        public Guid AppWareHouseId { get; set; }
        public string AppWareHouseName { get; set; }
        public decimal AppWareHouseNetItemCost { get; set; }
        public string AppWareHouseLoctaionCity { get; set; }
        public string AppWareHosueLocationCountryCode { get; set; }
        public string AppWareHouseStreetAddress { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
