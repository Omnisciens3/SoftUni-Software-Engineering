using E11.StorageMaster.Core;
using E11.StorageMaster.Factories;
using E11.StorageMaster.IO;
using System;

namespace E11.StorageMaster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var productFactory = new ProductFactory();
            var storageFactory = new StorageFactory();

            StorageMaster.Core.StorageMaster storageMaster = new StorageMaster.Core.StorageMaster(productFactory, storageFactory);
            var consoleDataReader = new ConsoleDataReader();
            var consoleDataWriter = new ConsoleDataWriter();

            var engine = new Engine(storageMaster, consoleDataReader, consoleDataWriter);

            engine.Run();
        }
    }
}
