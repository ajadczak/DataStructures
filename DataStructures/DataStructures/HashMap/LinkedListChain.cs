using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.HashMap.Interfaces;

namespace DataStructures.HashMap
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedListChain<K, V> : IChainProvider<K, V>
    {
        private LinkedList<V> linkedList = new LinkedList<V>();

        public void Insert(V value)
        {
            LinkedListNode<V> node = new LinkedListNode<V>(value);
            linkedList.AddLast(node);
        }

        public void Clear()
        {
            linkedList.Clear();
        }

        public V Get(V value)
        {
            return default(V);
        }

        public IEnumerator<V> GetEnumerator()
        {
            return linkedList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return linkedList.GetEnumerator();
        }
    }
}
