using System.Runtime.CompilerServices;

namespace CallerInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task();
            task.TraceMessage("Hello");
        }
    }

    public class Task
    {
        public void TraceMessage(string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            System.Console.WriteLine("실행 내용 : " + message);
            System.Console.WriteLine("맴버 이름 : " + memberName);
            System.Console.WriteLine("소스 경로 : " + sourceFilePath);
            System.Console.WriteLine("실행 라인 : " + sourceLineNumber);
        }
    }
}
