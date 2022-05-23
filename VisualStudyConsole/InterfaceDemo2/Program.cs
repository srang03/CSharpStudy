namespace InterfaceDemo2
{
    public interface IBattery
    {
        string GetName();
    }

    public class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }

    public class Bad : IBattery
    {
        public string GetName() => "Bad";
    }

    public class Car
    {
        private IBattery _battery;

        public Car(IBattery battery)
        {
            this._battery = battery;
        }

        public void Run() => System.Console.WriteLine("{0} 자동차가 달립니다.", _battery.GetName());

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var good = new Car(new Good());
            good.Run();
            var bad = new Car(new Bad());
            bad.Run();
        }
    }
}
