using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.HashMap.Interfaces
{
    /// <summary>
    /// Transform any type T into a 32 bit unsigned integer hash value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHashProvider<V>
    {
        UInt32 Hash(V value);
    }
}
