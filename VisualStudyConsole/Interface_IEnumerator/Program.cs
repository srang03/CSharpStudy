using System.Collections;
using System;

namespace Interface_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "닷넷 코리아", "비주얼 아카데미" };
            
            foreach (string name in names)
            {
                System.Console.WriteLine(name);
            }
            using (var t = new Finish())
            {
                IEnumerator list = names.GetEnumerator();
                while (list.MoveNext())
                {
                    Console.WriteLine(list.Current);
                }
            }
         
        }
    }
    public class Finish : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("바이");
        }
    }
}
