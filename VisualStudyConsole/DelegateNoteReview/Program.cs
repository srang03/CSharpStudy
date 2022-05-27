using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateNoteReview
{
    class Program
    {
        public delegate void GoHome();
        static void Main(string[] args)
        {
            GoHome goHome = new GoHome(CarDriver.직진);

            goHome += CarDriver.직진;
            goHome += CarDriver.좌회전;
            goHome += CarDriver.우회전;

            goHome += () => Console.WriteLine("도착");

            goHome.Invoke();
        }
    }
    
    public class CarDriver
    {
        public static void 직진() => Console.WriteLine("직진");
        public static void 좌회전() => Console.WriteLine("좌회전");
        public static void 우회전() => Console.WriteLine("우회전");
    }
}
