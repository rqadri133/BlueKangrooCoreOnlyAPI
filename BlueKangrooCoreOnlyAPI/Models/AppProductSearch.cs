using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppProductSearch
    {
        public Guid AppProductSearchId { get; set; }
        public string AppProductSeacrhRule { get; set; }
        public Guid AppProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
