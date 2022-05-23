using System;

namespace InterfaceNote
{
    public interface IStandard
    {
        void Left(); // 강제
    }

    internal abstract class KS // 설계를 주는 목적
    {
        public abstract void Back();
    }

    partial class MyCar : KS
    {
        public override void Back()
        {
            Console.WriteLine("Back");
        }
    }

    partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("Turn Right");
    }

    class Car : MyCar, IStandard
    {
        Action<string> printf = Console.WriteLine;

        public void Left() => Console.WriteLine();


        public void Run() => printf("Run");

    }
    class SpyCar : Car
    {

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Right();
            car.Back();

        }
    }
}
