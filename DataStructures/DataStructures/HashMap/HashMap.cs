using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.HashMap.Interfaces;

namespace DataStructures
{
    /// <summary>
    /// User provides the implementation of the hash function and bucket chain functionality
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HashMap<K, V, T>
    {
        private IBucketProvider<K, V, T> bucketProvider;
        public HashMap(IBucketProvider<K, V, T> bucketProvider)
        {
            if (bucketProvider == null)
                throw new ArgumentNullException("bucketProvider");

            this.bucketProvider = bucketProvider;
        }

        public void Insert(V value)
        {
            bucketProvider.Insert(value);
        }

        public bool Remove(K value)
        {
            return bucketProvider.Remove(value);
        }

        public V Get(K value)
        {
            return bucketProvider.Get(value);
        }

        V this[K index]
        {
            get
            {
                return bucketProvider[index];
            }
            set
            {
                bucketProvider[index] = value;
            }
        }
    }
}
