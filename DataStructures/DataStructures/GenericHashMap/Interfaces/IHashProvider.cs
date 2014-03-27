using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.GenericHashMap.Interfaces
{
    /// <summary>
    /// Transform any type T into a 32 bit unsigned integer hash value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHashProvider<K>
    {
        UInt32 Hash(K value);
    }
}
