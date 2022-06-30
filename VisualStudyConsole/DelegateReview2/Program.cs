using System;

namespace DelegateReview2
{
    internal class Program
    {

        Del del;
        delegate void Del();
        static void Main(string[] args)
        {
            Del del = new Del(callbackfunc);
            del += delegate { Console.WriteLine("H2"); };
            del += () => { Console.WriteLine("H3"); };
            del += Out.callback;
            del.Invoke();
        }

        static void callbackfunc()
        {
            Console.WriteLine("Callback func is executing");
        }
    }

    public class Out
    {
        public static void callback()
        {
            Console.WriteLine("callback");
        }
    }
}
