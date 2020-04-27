using System;
using System.Runtime.Caching;
namespace pe.donbiz.service.webAPI.Models.CrossCutting.Caching
{
    public class CacheDomain
    {
        static readonly ObjectCache Cache = MemoryCache.Default;
        public static void Add(object objectToCache, string key)
        {
            ObjectCache cache = MemoryCache.Default;
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddHours(6.0);
            cache.Add(key, objectToCache, policy);
        }
        public static T Get<T>(string key) where T : class
        {
            try
            {
                return (T)Cache[key];
            }
            catch
            {
                return null;
            }
        }
    }
}
