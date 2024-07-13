using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class ApplicationContext
    {
        public Guid ApplicationContextId { get; set; }
        public string ApplicationContextName { get; set; }
        public string AppClientId { get; set; }
        public string AppClientSecretKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
