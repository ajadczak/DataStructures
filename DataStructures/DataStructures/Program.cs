using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.GenericHashMap;
using DataStructures.GenericHashMap.Interfaces;
using DataStructures.GenericHashMap.Implementations;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicHash<string> stringHasher = new BasicHash<string>();
            ArrayBucket<string, Model> bucket = new ArrayBucket<string, Model>(stringHasher);
            GenericHashMap<string, Model> modelMap = new GenericHashMap<string, Model>(bucket);

            Model modelData = new Model();
            modelData.LoadData();
            modelMap.Insert("TestModel", modelData);
            modelMap.Insert("TestModel2", modelData);
            modelMap.Insert("TestModel", modelData); 
            modelMap.Remove("TestModel");
        }

        /// <summary>
        /// Some sample data
        /// </summary>
        private class Model
        {
            public void LoadData()
            {

            }
        }
    }
}
