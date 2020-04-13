using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueKangrooCoreOnlyAPI.Caching
{
    public class CacheManager<T>  : ICacheManager<T>  
    {
        public async Task<List<T>> ProcessCache(List<T> dataFetch, string cacheKey, byte[] encodedbytes, IConfiguration configuration , IDistributedCache distributedCache)
        {
            string serilaizedData = String.Empty;
            if (encodedbytes != null)
            {
                serilaizedData = Encoding.UTF8.GetString(encodedbytes);
                dataFetch = JsonConvert.DeserializeObject<List<T>>(serilaizedData);
            }
            else
            {

                serilaizedData = JsonConvert.SerializeObject(dataFetch);
                encodedbytes = Encoding.UTF8.GetBytes(serilaizedData);
                var options = new DistributedCacheEntryOptions()
                                 .SetAbsoluteExpiration(DateTime.Now.AddHours(Convert.ToInt32(configuration["CacheAbsoluteExpirations"])))
                                 .SetSlidingExpiration(TimeSpan.FromMinutes(Convert.ToInt32(configuration["SlidingExpirationsTimeOutInMinutes"])));

                await distributedCache.SetAsync(cacheKey, encodedbytes, options);
            }

            return dataFetch;

        }

       
    }
}
