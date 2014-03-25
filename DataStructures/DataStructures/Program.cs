using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.HashMap;
using DataStructures.HashMap.Interfaces;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compose a hash map that uses a basic hash for mapping keys to values,
            // an array for storing buckets, and a linked list for chains
            BasicHash<string> basicHash = new BasicHash<string>();
            var arrayBucket = new ArrayBucket<int, string>(basicHash);
            HashMap<int, string> hashMap = new HashMap<int, string>(arrayBucket);
            hashMap.Insert("Test");
            hashMap.Insert("Test");
        }
    }
}
