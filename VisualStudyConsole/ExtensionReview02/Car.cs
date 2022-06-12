using System;

namespace ExtensionReview02
{
    public class Car
    {
        private string name;
        public Car(string name)
        {
            this.name = name;
        }
        public void Run() => Console.WriteLine($"{this.name}이 달립니다.");
    }
}
