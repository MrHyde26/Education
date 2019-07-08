using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Education
{
    public class CountsFolders
    {
        private const string Path = "C:\\Windows\\System32";
        //private const string Path = "F:\\123";

        public void Execute()
        {
            int counter = 0;
            DirectoryInfo dir = new DirectoryInfo(Path);
            foreach (var item in dir.GetDirectories())
            {
                counter++;
            }
            long size = GetDirectorySize(Path);
            //long size = 0;
            
            Console.WriteLine($"Directories: {counter}. Size: {size}");
        }

        private long GetDirectorySize(string directoryPath)
        {
            long size = 0;
            DirectoryInfo dir = new DirectoryInfo(directoryPath);
            try
            {
                foreach (FileInfo item in dir.GetFiles())
                {
                    size += item.Length;
                }
                if (Directory.GetDirectories(directoryPath).Length != 0)
                {
                    foreach (var item in Directory.GetDirectories(directoryPath))
                    {
                        Console.WriteLine(item);
                        size += GetDirectorySize(item);
                    }
                }
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            return size;
        }
    }
}
