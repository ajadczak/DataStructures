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
    /// <typeparam name="T"></typeparam>
    public class BasicHash<V> : IHashProvider<V>
    {
        public UInt32 Hash(V value)
        {
            return (UInt32)value.GetHashCode();
        }
    }
}
