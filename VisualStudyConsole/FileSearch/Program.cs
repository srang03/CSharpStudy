using System;
using System.IO;
using System.Linq;

namespace FileSearch
{

    internal class Program
    {
        private static string _path = @"C:\Users\Ian\Desktop\ian\C#\CSharpStudy";

        static void Main(string[] args)
        {

            Console.WriteLine("파일 확장자를 입력해주세요.");
            var extension = Console.ReadLine();

            GetFiles(_path, extension);
        }

        public static void GetFiles(string path, string extension)
        {
            string[] directories = Directory.GetDirectories(path, $"*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(path, $"*.{extension}", SearchOption.AllDirectories);

            Console.WriteLine("검색할 단어를 입력해주세요.");
            var word = Console.ReadLine();
            var filtered_file = files.Where(f => new FileInfo(f).Name.Contains(word));
            foreach (string file in filtered_file)
            {
                FileInfo fileinfo = new FileInfo(file);
                Console.WriteLine($"{fileinfo.DirectoryName}");
            }

            Console.WriteLine($"총 {filtered_file.ToList().Count}개 입니다");
        }
    }
}

