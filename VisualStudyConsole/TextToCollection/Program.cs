using System;
using System.Collections.Generic;
using System.IO;

namespace TextToCollection
{
    public struct Record
    {
        public string Name;
        public string PhoneNumber;
        public DateTime Date;
        public string AuthoCode;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var dir = "C:\\Users\\Ian\\Desktop\\ian\\Src.txt";

            // [1] 파일 읽고 출력
            string[] lines = File.ReadAllLines(dir, System.Text.Encoding.Default);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // [2] 문자열 정보를 컬렉션에 담기
            List<Record> list = new List<Record>();
            foreach (var line in lines)
            {
                string[] splitData = line.Split(",");
                list.Add(new Record()
                {
                    Name = splitData[0],
                    PhoneNumber = splitData[1],
                    Date = DateTime.Parse(splitData[2]),
                    AuthoCode = splitData[3]
                });
            }

            // [3] 전체 정보 출력
            foreach(var data in list)
            {
                Console.WriteLine($"[{data.AuthoCode}] {data.Name} {data.Date.ToShortDateString()} {data.PhoneNumber}");
            }

        }
    }
}
