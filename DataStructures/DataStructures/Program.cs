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
            BasicHash<string> basicHash = new BasicHash<string>();
            ArrayBucket<uint, string> arrayBucket = new ArrayBucket<uint, string>(basicHash);
            HashMap<uint, string> hashMap = new HashMap<uint, string>(arrayBucket);
            hashMap.Insert("Test");
        }
    }
}
