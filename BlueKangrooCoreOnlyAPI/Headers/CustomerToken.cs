using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueKangrooCoreOnlyAPI.Models;
namespace BlueKangrooCoreOnlyAPI.Headers
{
    public class CustomerToken
    {
        public string customerTokenId { get; set; }
        public string tokenDescription { get; set; }
        public List<AppUserRoleDetail> TemplateRoles { get; set; }
        // must return TemplateRoles

    }
}
