using System;
using System.IO;
using System.Threading;

namespace StreamWriterWriteLineDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = "안녕하세요\r\n반갑습니다." + Environment.NewLine + "또 만나요";
            var path = "C:\\Users\\Ian\\Desktop\\ian\\Test.txt";
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(data);

            sw.Close();
            sw.Dispose();

            Thread.Sleep(1000);
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            sr.Dispose();

        }
   }
}
