using System;
using System.Collections.Generic;

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class AppJsonfile
    {
        public Guid AppJsonfileId { get; set; }
        public string AppJsonfileName { get; set; }
        public string AppJsonfileUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
