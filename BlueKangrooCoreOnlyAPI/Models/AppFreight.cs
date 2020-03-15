using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppFreight
    {
        public Guid AppFreightId { get; set; }
        public string AppFreightName { get; set; }
        public Guid AppFreightCarrierTypeId { get; set; }
        public string AppFreightDesc { get; set; }
        public decimal AppFreightWeight { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
