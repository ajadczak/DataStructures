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
    public class LinkedListChain<T> : IChainProvider<T>
    {
        private LinkedList<T> linkedList = new LinkedList<T>();

        public void Insert(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            linkedList.AddLast(node);
        }

        public bool Remove(T value)
        {
            return linkedList.Remove(value);
        }

        public void Clear()
        {
            linkedList.Clear();
        }

        public T Get(T value)
        {
            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
