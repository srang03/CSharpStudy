using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditional_2
{
    // ?. 연산자 : 컬렉션(리스트,딕셔너리,배열)이 null 이면 null을 반환, 그렇지 않을 경우 연산자 뒤의 속성 값을 반환
    // Elvis 연산자 (엘비스 연산자는 프레슬리 머리 모양과 비슷하다고 하여 Elvis 연산자라고도 한다.) 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = null;
            int? numberOfList; // Nullable 변수

            // [1] 리스트가 null이면 null을 반환
            // 엘비스 연산자 또는 널 조건부 연산자
            numberOfList = list?.Count; // list가 null이면 null반환, 아니면 Count 반환

            if (numberOfList == null)
            {
                Console.WriteLine($"[1] 리스트 카운트는 null 입니다.");
            }

            list = new List<string>();
            list.Add("하이"); list.Add("바이");

            // [2] 리스트의 값이 null이 아니므로 Count 속성 값인 2를 반환한다.
            numberOfList = list?.Count;

            if(numberOfList != null)
            {
                Console.WriteLine($"[2] 리스트 카운트는 {numberOfList}입니다.");
            }

            

        }
    }
}
