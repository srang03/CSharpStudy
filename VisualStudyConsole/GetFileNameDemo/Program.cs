using System;
using System.IO;

namespace GetFileNameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------- 1. 문자열 파일 이름 추출
            // [1] 입력
            string dir = "C:\\Users\\Ian\\Desktop\\ian\\icon.png";
            string fullName = String.Empty;
            string name = "";
            string ext = name;

            // [2] 처리
            fullName = dir.Substring(dir.LastIndexOf('\\') + 1); // 파일명 전체
            name = fullName.Substring(0, fullName.LastIndexOf('.')); // 파일명
            ext = fullName.Substring(fullName.LastIndexOf('.') + 1); // 확장자

            // [3] 출력 
            Console.WriteLine("[1] 문자열 파일 이름 추출");
            Console.WriteLine($"전체 파일 이름 : [{fullName}]");
            Console.WriteLine($"파일 이름 : [{name}]");
            Console.WriteLine($"파일 확장자 : [{ext}]");

            Console.WriteLine("----------------------------------");
            // ------------------- 2. Path 클래스 파일 정보 GET
            Console.WriteLine("[2] Path 클래스 파일 정보 GET");
            Console.WriteLine(Path.GetFullPath(dir));
            Console.WriteLine(Path.GetFileName(dir));
            Console.WriteLine(Path.GetFileNameWithoutExtension(dir));
            Console.WriteLine(Path.GetExtension(dir));


        }
    }
}
