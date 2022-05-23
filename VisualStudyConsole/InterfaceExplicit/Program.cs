namespace InterfaceExplicit
{
    public interface IDog
    {
        void Eat();
    }

    public interface ICat
    {
        void Eat();
    }

    public class MyPet : IDog, ICat
    {
        void IDog.Eat() => System.Console.WriteLine("Dog Eat");
        void ICat.Eat() => System.Console.WriteLine("Cat Eat");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
