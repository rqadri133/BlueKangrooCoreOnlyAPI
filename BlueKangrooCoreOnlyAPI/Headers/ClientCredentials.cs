using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Headers
{
    public class ClientCredentials
    {
        public string client_id
        {
            get;
            set;
        }

        public string client_secret
        {
            get;
            set;
        }

        public string audience
        {
            get;
            set;
        }

        public string grant_type
        {
            get;
            set;
        }
            
      }
}
