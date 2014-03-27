using DataStructures.GenericHashMap.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.GenericHashMap
{
    public class BasicHash<V> : IHashProvider<V>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public UInt32 Hash(V value)
        {
            return (UInt32)value.GetHashCode();
        }
    }
}