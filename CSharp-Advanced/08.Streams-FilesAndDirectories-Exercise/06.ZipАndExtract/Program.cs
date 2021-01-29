using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipАndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE!: For the program to work please extract "06.ZipАndExtract" folder from the .zip file on your Desktop!!!


            using (FileStream fs = new FileStream(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\06.ZipАndExtract\result.zip", FileMode.Create))
            {
                using (ZipArchive arch = new ZipArchive(fs, ZipArchiveMode.Create))
                {
                    arch.CreateEntryFromFile(@$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\06.ZipАndExtract\copyMe.png", "copyMe.png");
                }
            }
        }
    }
}
