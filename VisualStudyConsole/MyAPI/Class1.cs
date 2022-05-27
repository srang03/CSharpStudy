using System;

namespace MyAPI
{
    public class Program
    {
        public static int[] SelectOrder(int[] list)
        {
            int N = list.Length;

            for(int i = 0; i < N-1; i++)
            {
                for(int j = i+1; j < list.Length; j++)
                {
                    if(list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;   
        }

        public static bool IsEven(int x)
        {
            return x % 2 == 0;
        }
        public static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }

    }
}
