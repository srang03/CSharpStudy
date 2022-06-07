using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoReivew220606
{
    class Program
    {

        delegate void SayDelegate();

        static void Main(string[] args)
        {
            SayDelegate func = new SayDelegate(SpeakLoud);
            func.Invoke();
            

        }

        static void SpeakLoud()
        {
            Console.WriteLine("Hi");
        }
    }
}
