using System;
using System.Collections.Generic;

#nullable disable

namespace BlueKangrooCoreOnlyAPI.Models
{
    public partial class Applocation
    {
        public Guid Applocationid { get; set; }
        public string Appgeolocation { get; set; }
        public string Applocationaddress { get; set; }
        public string Applocationcity { get; set; }
        public string Applocationcountrycode { get; set; }
        public string Applocationstatecode { get; set; }
        public DateTime Createddate { get; set; }
        public DateTime Createdby { get; set; }
    }
}
