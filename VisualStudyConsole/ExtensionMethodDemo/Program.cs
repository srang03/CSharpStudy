namespace ExtensionMethodDemo2
{
    public class Program
    {
      
    }
}

namespace ExtensionMethodDemo
{
    static class Extension
    {
        public static string Five(this string msg)
        {
            return msg.Substring(0, 5);
        }
        public static string AddElipsis(this string msg) => msg + "...";

        public static string AddElipsis(this string msg, string elipsis) => $"{msg} {elipsis}";

        public static int PlusOne(this int number)
        {
            return number + 1;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string message = "안녕하세요. 반갑습니다.";
            System.Console.WriteLine(message.Five().AddElipsis("호이"));

            int a = 10;
            a.PlusOne();
            
        }
    }

}
