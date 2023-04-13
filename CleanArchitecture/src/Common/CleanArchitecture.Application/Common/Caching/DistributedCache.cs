using CleanArchitecture.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Caching
{
    public static class CacheKey
    {
        public const string TranslationQueryKey = "TranslationQuery";
    }

    public class Caching
    {
        private readonly IDistributedCache _cache;

        public Caching(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async void SetCache(string cacheKey, string cacheData)
        {
            var dataToCache = Encoding.UTF8.GetBytes(cacheData);
            DistributedCacheEntryOptions options = new DistributedCacheEntryOptions().SetAbsoluteExpiration(DateTime.Now.AddMinutes(5)).SetSlidingExpiration(TimeSpan.FromMinutes(3));
            await _cache.SetAsync(cacheKey, dataToCache, options);
        }

        public async Task<string> GetCache(string cacheKey)
        {
            byte[] cachedData = await _cache.GetAsync(cacheKey);
            return cachedData == null ? null : Encoding.UTF8.GetString(cachedData);
        }

        public async void RemoveCache(string cacheKey)
        {
            await _cache.RemoveAsync(cacheKey);
        }
    }
}