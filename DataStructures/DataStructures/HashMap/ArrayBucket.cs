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
    public class ArrayBucket<K, V, T>  : IBucketProvider<K, V, T> where T : IChainProvider<K, V>, new()
    {
        private int capacity;
        private int size;
        private IHashProvider<V> hashProvider;
        
        // Array of chain type T
        T[] bucket;

        public ArrayBucket(IHashProvider<V> hashProvider)
        {
            if(hashProvider == null)
                throw new ArgumentNullException("hashProvider");

            this.capacity = 0;
            this.size = 0;
            bucket = new T[0];
            this.hashProvider = hashProvider;
        }

        public ArrayBucket(IHashProvider<V> hashProvider, int capacity)
        {
            if (hashProvider == null)
                throw new ArgumentNullException("hashProvider");
            if (capacity < 0 || capacity > int.MaxValue)
                throw new ArgumentOutOfRangeException("capacity");

            this.capacity = capacity;
            this.size = 0;
            bucket = new T[capacity];
            this.hashProvider = hashProvider;
        }

        public void Insert(V value)
        {
            // check to see if array needs to grow
            if(size == capacity)
            {
                T[] temp = new T[capacity * 2];
                Array.Copy(bucket, temp, size);
                bucket = temp;
            }

            var hash = hashProvider.Hash(value);
            var index = hash % capacity;
            if(bucket[index] == null)
            {
                bucket[index] = new T();
            }

            var chain = bucket[index];
            chain.Insert(value);
        }

        public bool Remove(K key)
        {
            
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
