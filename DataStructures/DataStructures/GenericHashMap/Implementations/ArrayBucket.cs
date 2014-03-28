using DataStructures.GenericHashMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.GenericHashMap.Implementations
{
    public class ArrayBucket<K, V> : IBucketProvider<K, V>
    {
        private int capacity;
        private int size;
        private IHashProvider<K> hashProvider;
        private LinkedList<KeyValuePair<K, V>>[] bucket;
        private bool fastIndex = false;

        public ArrayBucket(IHashProvider<K> hashProvider) : this(hashProvider, 16) { }
        public ArrayBucket(IHashProvider<K> hashProvider, int capacity)
        {
            if (hashProvider == null)
                throw new ArgumentNullException("hashProvider");
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException("capacity");

            this.hashProvider = hashProvider;
            this.capacity = capacity;
            this.bucket = new LinkedList<KeyValuePair<K, V>>[capacity];
            this.size = 0;
            this.fastIndex = IsPowerOfTwo((uint)capacity);
        }

        /// <summary>
        /// Check if number is a power of 2. The logic works like this:
        /// First catch if number is 0 as this is a corner case where all the bits in the 
        /// value would be zero, which would incorrectly evaluate as a power of 2.
        /// Next we 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool IsPowerOfTwo(uint number)
        {
            return (number != 0) && ((number & (number - 1)) == 0);
        }

        public void Insert(KeyValuePair<K, V> kvp)
        {
            if (size == capacity)
                Grow();

            var hash = Math.Abs(hashProvider.Hash(kvp.Key));
            var index = getIndex((uint)hash);
            
            if(bucket[index] == null)
            {
                bucket[index] = new LinkedList<KeyValuePair<K, V>>();
                bucket[index].AddLast(kvp);
                size++;
                return;
            }

            // Check to see if the key already exists
            // The search for values can be sped up if using something other than a linked list,
            // perhaps a tree structure. This depends on how deep the buckets get, which depends on the 
            // hashing algo and capacity. 
            foreach(var keyValue in bucket[index])
            {
                if(kvp.Key.Equals(keyValue.Key))
                {
                    // the KeyValuePair type is immutable so recreate to update the value
                    bucket[index].Remove(keyValue);
                    bucket[index].AddFirst(new KeyValuePair<K,V>(kvp.Key, kvp.Value));
                    return;
                }
            }

            bucket[index].AddLast(kvp);
            size++;
        }


        public bool Remove(K key)
        {
            var hash = hashProvider.Hash(key);
            var index = getIndex(hash);

            if (bucket[index] == null)
                return false;

            foreach (var keyValue in bucket[index])
            {
                if (key.Equals(keyValue.Key))
                {
                    // the KeyValuePair type is immutable so recreate to update the value
                    bucket[index].Remove(keyValue);
                    return true;
                }
            }

            return false;
        }

        public V Get(K key)
        {
            return this[key];
        }

        public V this[K key]
        {
            get
            {
                var hash = hashProvider.Hash(key);
                var index = getIndex(hash);
                return bucket[index].Single(k => k.Key.Equals(key)).Value;
            }
            set
            {
                this.Insert(new KeyValuePair<K, V>(key, value));
            }
        }

        private int getIndex(uint hash)
        {
            if (fastIndex)
                return (int)(hash & (capacity - 1));
            else
                return (int)(hash % capacity);
        }

        private void Grow()
        {

        }
    }
}
