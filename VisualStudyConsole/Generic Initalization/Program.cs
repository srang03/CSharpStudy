using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] 객체 형식 리스트 생성 : 컬렉션 이니셜라이저로 값 초기화
            List<Insolation> insolations = new List<Insolation>()
            {
                new Insolation { Month = 1, Value = 0.3f},
                new Insolation { Month = 2, Value = 0.6f},
                new Insolation { Month = 3, Value = 0.9f},
                new Insolation { Month = 4, Value = 1.2f}
            };

            // [2] Add() 메서드로 리스트에 값 추가 : 객체 이니셜라이저로 값 초기화
            insolations.Add(new Insolation() { Month = 5, Value = 1.5f });
            insolations.Add(new Insolation() { Month = 6, Value = 1.8f });
            insolations.Add(new Insolation() { Month = 7, Value = 2.1f });
            insolations.Add(new Insolation() { Month = 8, Value = 2.4f });

            // [3] AddRange() 메서드로 리스트에 값들을 추가
            var tempInsolations = new List<Insolation>()
            {
                new Insolation { Month = 9, Value = 2.7f },
                new Insolation { Month = 10, Value = 3.0f },
                new Insolation { Month = 11, Value = 3.3f },
                new Insolation { Month = 12, Value = 3.6f }
            };

            insolations.AddRange(tempInsolations);

            foreach(var insolation in insolations)
            {
                Console.WriteLine($"{insolation.Month} : {insolation.Value}");
            }
        }
    }
    public class Insolation
    {
        public int Month { get; set; } // 월
        public float Value { get; set; } // 일사량 값
    }



}
