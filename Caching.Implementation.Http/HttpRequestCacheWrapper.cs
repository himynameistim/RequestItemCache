using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching.Implementation.Http
{
    public class HttpRequestCacheWrapper : IHttpRequestCacheWrapper
    {
        //private readonly HttpContextProvider _contextProvider;

        //public HttpRequestCacheWrapper(HttpContextProvider contextProvider)
        //{
        //    _contextProvider = contextProvider;
        //}

        //private IDictionary Items => _contextProvider.Context.Items;

        //public T Get<T>(string key)
        //{
        //    var item = Items[key];

        //    return (item is T) ? (T)item : default(T);
        //}

        //public void Set<T>(string key, T value)
        //{
        //    Items[key] = value;
        //}

        //public void Remove(string key)
        //{
        //    Items.Remove(key);
        //}

        //public object this[string key]
        //{
        //    get { return Items[key]; }
        //    set { Items[key] = value; }
        //}

        //public bool Contains(string key)
        //{
        //    return Items.Contains(key);
        //}
    }
}
