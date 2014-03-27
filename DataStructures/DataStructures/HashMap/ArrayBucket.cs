using DataStructures.HashMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashMap
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="K">Key type for hashing</typeparam>
    /// <typeparam name="V">Value type for storing</typeparam>
    /// <typeparam name="T">Chain type</typeparam>
    public class ArrayBucket<K, V>  : IBucketProvider<K, V>
    {
        private int capacity;
        private int size;
        private IHashProvider<V> hashProvider;
        LinkedList<V>[] bucket;

        private bool fastIndex;

        private bool IsPowerOfTwo(ulong num)
        {
            return (num != 0) && (num & (num - 1)) == 0;
        }
        
        public ArrayBucket(IHashProvider<V> hashProvider) : this(hashProvider, 16) {}

        public ArrayBucket(IHashProvider<V> hashProvider, int capacity)
        {
            if (hashProvider == null)
                throw new ArgumentNullException("hashProvider");
            if (capacity < 0 || capacity > int.MaxValue)
                throw new ArgumentOutOfRangeException("capacity");
            //if(!IsPowerOfTwo((ulong)capacity))
                //throw new ArgumentException("Capacity must be a power of two");

            this.capacity = capacity;
            this.size = 0;
            bucket = new LinkedList<V>[capacity];
            this.hashProvider = hashProvider;
            
            // If capacity is a power of 2 then we can do hash & (size - 1) to get the index
            // otherwise use hash % capacity to get index

            fastIndex = IsPowerOfTwo((ulong)capacity);
        }

        public void Insert(V value)
        {
            int index = 0;
            // check to see if array needs to grow
            if(size == capacity)
            {
                capacity++;
                LinkedList<V>[] temp = new LinkedList<V>[capacity * 2];
                //rehash all values and reinsert into new buckets
                foreach(var chain in bucket)
                {
                    for(var entry = chain.First; entry != chain.Last; entry = entry.Next)
                    {
                        var rehash = hashProvider.Hash(entry.Value);
                        index = 0;
                        if (fastIndex)
                            index = (int)(rehash & (capacity - 1));
                        else
                            index = (int)(rehash % capacity);

                        if(temp[index] == null)
                        {
                            temp[index] = new LinkedList<V>();
                        }
                        
                        temp[index].AddLast(entry.Value);
                    }
                }

                bucket = temp;
            }

            var hash = Math.Abs(hashProvider.Hash(value));
            if (fastIndex)
                index = (int)(hash & (capacity - 1));
            else
                index = (int)(hash % capacity);

            
            if(bucket[index] == null)
            {
                bucket[index] = new LinkedList<V>();
                //KeyValuePair<K, V> kvp = new KeyValuePair<K,V>();
                //bucket[index].AddLast(kvp);
            }
            else
            {
                //bucket[index].
                if(bucket[index].Contains(value))
                {

                }
            }

            
            size++;
        }

        public bool Remove(K key)
        {
            return true;
        }

        public bool Remove(V value)
        {
            throw new NotImplementedException();
        }

        public V Get(K key)
        {
            throw new NotImplementedException();
        }

        public K GetKey(V value)
        {
            throw new NotImplementedException();
        }


        public V this[K index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
