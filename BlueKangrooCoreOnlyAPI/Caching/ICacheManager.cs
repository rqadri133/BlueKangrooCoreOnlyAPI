using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using config = Microsoft.Extensions.Configuration;
namespace BlueKangrooCoreOnlyAPI.Caching
{
    public interface ICacheManager<T>
    {
        Task<List<T>> ProcessCache(List<T> dataFetch, string cacheKey, byte[] encodedbytes, config.IConfiguration configuration  , IDistributedCache distributedCache);


    }
}
