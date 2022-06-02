using System;
using System.IO;

namespace FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Users\\Ian\\Desktop\\ian\\Test.txt";

            if (File.Exists(file))
            {
                FileInfo fi = new FileInfo(file);
                Console.WriteLine(fi.FullName);
                Console.WriteLine(fi.CreationTime);
                Console.WriteLine(fi.Extension);
                Console.WriteLine($"{File.GetCreationTime(file)}");
                Console.WriteLine($"{fi.Exists}");
                File.Copy(file, "C:\\Users\\Ian\\Desktop\\ian\\Test2.txt",true);

            }
        }
    }
}
