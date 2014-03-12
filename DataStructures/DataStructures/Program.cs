using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHash<string> hash = new BasicHash<string>();
            LinkedListChain<string> chain = new LinkedListChain<string>();
            HashMap<string> objectMap = new HashMap<string>(hash, chain);
            
            string myData = "Some object data";
            objectMap.Insert(myData);

            var val = objectMap.Get(myData);

            HashSet<string> hashSet = new HashSet<string>();
        }
    }
}
