using System;
using System.Collections.Generic;
using System.Text;

namespace advanced01
{
    public class CacheItem<TValue>
    {
        public TValue Value { get; set; }
        public DateTime ExpiryTime { get; set; }
    }

    public class Cache<TKey, TValue> where TKey : notnull
    {
        private Dictionary<TKey, CacheItem<TValue>> _cache = new Dictionary<TKey, CacheItem<TValue>>();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            var expiration = DateTime.Now.Add(duration);
            _cache[key] = new CacheItem<TValue> { Value = value, ExpiryTime = expiration };
        }

        public TValue Get(TKey key)
        {
            if (!_cache.ContainsKey(key)) return default(TValue);

            var item = _cache[key];
            if (DateTime.Now > item.ExpiryTime)
            {
                _cache.Remove(key);
                return default(TValue);
            }

            return item.Value;
        }

        public void Remove(TKey key)
        {
            _cache.Remove(key);
        }

        public bool Contains(TKey key)
        {
            if (!_cache.ContainsKey(key)) return false;
            if (DateTime.Now > _cache[key].ExpiryTime)
            {
                _cache.Remove(key);
                return false;
            }
            return true;
        }
    }
}
