using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Core.CrossCuttingConcerns.Caching.Redis
{
    public class RedisCacheManager : ICacheManager // Redis için cache ayarlanacak
    {
        public void Add(string key, object value, int duration)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public object Get(string key)
        {
            throw new NotImplementedException();
        }

        public bool IsAdd(string key)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveByPattern(string pattern)
        {
            throw new NotImplementedException();
        }
    }
}
