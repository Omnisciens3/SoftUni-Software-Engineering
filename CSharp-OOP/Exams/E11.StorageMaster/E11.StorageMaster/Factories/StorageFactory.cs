using E11.StorageMaster.Models.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace E11.StorageMaster.Factories
{
    public class StorageFactory
    {
        public Storage CreateStorage(string type, string name)
        {
            var storageType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .Where(x => !x.IsAbstract && x.Name == type)
                .FirstOrDefault();

            if (storageType == null)
            {
                throw new InvalidOperationException("Invalid storage type!");
            }

            var storage = (Storage)Activator.CreateInstance(storageType, name);

            return storage;
        }
    }
}
