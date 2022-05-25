namespace ExtensionMethodNote
{
    public class OriginalClass { }

    public static class OriginalClassExtensions
    {
        public static void ExtensionMethod(this OriginalClass obj)
        {
            System.Console.WriteLine("새로운 메서드 추가");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OriginalClass originalClass = new OriginalClass();
            originalClass.ExtensionMethod();

        }
    }
}
