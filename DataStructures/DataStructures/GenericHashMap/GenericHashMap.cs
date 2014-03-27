using DataStructures.GenericHashMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.GenericHashMap
{
    public class GenericHashMap<K, V>
    {
        private IBucketProvider<K, V> bucketProvider;

        public GenericHashMap(IBucketProvider<K, V> bucketProvider)
        {
            if (bucketProvider == null)
                throw new ArgumentNullException("bucketProvider");

            this.bucketProvider = bucketProvider;
        }

        public void Insert(K key, V value)
        {
            var kvp = new KeyValuePair<K, V>(key, value);
            bucketProvider.Insert(kvp);
        }

        public bool Remove(K key)
        {
            return bucketProvider.Remove(key);
        }
    }
}
