using DataStructures.HashMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashMap
{
    public class ArrayBucket<K, V> : IBucketProvider<K, V>
    {
        private int capacity;
        private int size;
        private IHashProvider<V> hashProvider;
        int[] bucket;

        public ArrayBucket(IHashProvider<V> hashProvider)
        {
            if(hashProvider == null)
                throw new ArgumentNullException("hashProvider");

            this.capacity = 0;
            this.size = 0;
            bucket = new int[0];
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
            bucket = new int[capacity];
            this.hashProvider = hashProvider;
        }

        public void Insert(V value)
        {
            
            var hash = hashProvider.Hash(value);
        }

        public bool Remove(K key)
        {
            throw new NotImplementedException();
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
