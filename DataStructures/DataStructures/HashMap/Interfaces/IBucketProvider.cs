using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashMap.Interfaces
{
    /// <summary>
    /// Bucket holds chains. A hash function will get you to a bucket,
    /// then a chain provider can get you to the correct value.
    /// </summary>
    /// <typeparam name="K">Key type</typeparam>
    /// <typeparam name="V">Value type</typeparam>
    /// <typeparam name="T">Chain type</typeparam>
    public interface IBucketProvider<K, V, T>
    {
        void Insert(V value);
        bool Remove(K key);
        bool Remove(V value);
        V Get(K key);
        T GetKey(V value);
        V this[K index]
        {
            get;
            set;
        }
    }
}
