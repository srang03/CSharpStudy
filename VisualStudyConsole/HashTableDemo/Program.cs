using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();

            hashTable[0] = "text";
            hashTable.Add("txt", "notepad.exe");
            hashTable.Add("bmp", "paint.exe");
            hashTable.Add("dib", "paint.exe");
            hashTable.Add("rtf", "wordpad.exe");

            // 어떤 Key값에 해당되는 Value를 테이블의 어디에 저장할 것이냐 (암호화 영역)

            // Key 값
            // 해시 함수 Key값 
            // 해시 테이블 저장
        }
    }
}
