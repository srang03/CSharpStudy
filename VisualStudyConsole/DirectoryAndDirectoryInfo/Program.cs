using System;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = "C:\\";

            if (Directory.Exists(dir))
            {
                Console.WriteLine("[1] C드라이브의 모든 폴더 목록 출력");
                foreach (var item in Directory.GetDirectories(dir))
                {
                    Console.WriteLine(item);
                }
            }

            var di = new DirectoryInfo(dir);
            if (di.Exists)
            {
                Console.WriteLine("[2] C드라이브 모든 폴더 목록 출력");
                foreach (var item in di.GetDirectories())
                {
                    Console.WriteLine(item);
                }
                foreach (var item in di.GetFiles())
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
