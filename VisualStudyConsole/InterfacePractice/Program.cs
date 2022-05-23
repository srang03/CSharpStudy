namespace InterfacePractice
{
    public interface IRepository
    {
        void Get();
    }

    public class Repository : IRepository
    {
        public void Get() => System.Console.WriteLine("얻다");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository repository = new Repository();
            repository.Get();
        }
    }
}
