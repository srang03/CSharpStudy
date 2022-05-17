using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullalbeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<T> 구조체를 사용하여 null 사용 가능 형식 변수 만들기
            string message;
            Nullable<bool> bln = null; // 구조체는 생성자를 사용하지 않음

            if(bln.HasValue == true)
            {
                message = $"bln : {bln}";
             
            }
            else
            {
                message = "null입니다.";
            }

            
        }
    }
}
