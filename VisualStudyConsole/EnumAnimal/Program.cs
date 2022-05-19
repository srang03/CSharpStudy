using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAnimal
{

    // 열거형(Enumeration) : 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수 집합을 정의한다.
    enum Animal { Mouse, Cow, Tigger }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = Animal.Mouse;

            if(animal == Animal.Mouse)
            {
                Console.WriteLine("쥐입니다.");
            }

        }
    }
}
