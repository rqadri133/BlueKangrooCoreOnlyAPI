using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppShelve
    {
        public Guid AppShelveId { get; set; }
        public int AppShelveIndex { get; set; }
        public Guid AppCategoryId { get; set; }
        public decimal AppShelveHeight { get; set; }
        public decimal AppShelveWidth { get; set; }
        public int AppIsleNumber { get; set; }
        public decimal AppFreightWeight { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
