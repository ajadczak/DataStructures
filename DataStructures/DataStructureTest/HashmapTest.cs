using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.GenericHashMap;
using DataStructures.GenericHashMap.Implementations;

namespace DataStructureTest
{
    [TestClass]
    public class HashmapTest
    {
        [TestMethod]
        public void TestInsertAndRemove()
        {
            BasicHash<string> hash = new BasicHash<string>();
            ArrayBucket<string, int> simpleBucket = new ArrayBucket<string,int>(hash);
            GenericHashMap<string, int> map = new GenericHashMap<string,int>(simpleBucket);

            var testKey = "Test";
            var testValue = 5;
            map.Insert(testKey, testValue);
            bool result = map.Remove(testKey);

            Assert.IsTrue(result);
        }
    }
}
