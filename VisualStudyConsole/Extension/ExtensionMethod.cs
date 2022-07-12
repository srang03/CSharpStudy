using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    // 확장 메서드의 규칙 1. static 클래스를 생성한다.
    //                    2. static 함수의 첫 번째 인자로 확장 메서드의 타입, 두 번째 인자부터 매개변수로 사용한다.
    //                    3. 동일한 namespace 안에 위치해야한다.
    public static class ExtensionMethod
    {
        public static string ToPlus(this string a, string b)
        {
            return a + b;
        }
    }
}
