using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 절차 지향 프로그래밍 : 순서대로 입력 > 처리 > 출력 형태로 프로그래밍
// 알고리즘 
    // 초급 : 합계(SUM), 개수(COUNT), 평균(AVG), 최댓값(MAX), 최솟값(MIN)
    // 중급 : 최댓값 -> 최솟값, 최솟값 -> 최댓값, 최댓값 -> 최댓값, 최솟값 -> 최솟값, 최댓값- 최솟값
    // 고급 : 근삿값, 순위, 정렬 오름차순, 정렬 내림차순, 검색, 병합, 최빈값, 그룹

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] sort 메서드
            int[] data = { 3, 2, 1, 5, 4 };
            Array.Sort(data);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }


            // [2] OrderBy 메서드
            int[] data2 = { 3, 2, 1, 5, 4 };
            int[] res = data.OrderBy(x => x).ToArray();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            // [3] 선택정렬 메서드
            int[] data3 = { 3, 2, 1, 5, 4 };
            SelectedSort(data3);
        }

        static void SelectedSort(int[] data)
        {

            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        var temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            foreach (var item in data)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
