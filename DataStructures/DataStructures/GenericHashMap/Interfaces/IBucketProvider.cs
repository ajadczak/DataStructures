using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.GenericHashMap.Interfaces
{
    public interface IBucketProvider<K, V>
    {
        void Insert(KeyValuePair<K, V> kvp);
        bool Remove(K key);
    }
}
