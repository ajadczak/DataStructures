using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashMap.Interfaces
{
    /// <summary>
    /// Interface to provide basic insert, remove, get, and iterator functions.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IChainProvider<K, V> : IEnumerable<K>
    {
        void Insert(V value);
        //bool Remove(K key);
        bool Remove(V value);
        V Get(K key);
        V GetKey(V value);
        //V this[K index]
        //{
        //    get;
        //    set;
        //}
    }
}
