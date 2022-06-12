using System;

namespace OverrideReivew
{
    public class Child : Parent
    {
        public override void Say() => Console.WriteLine("자식 안녕하세요");
        public override void Run() => Console.WriteLine("자식 달리다.");
        public override void Walk() => Console.WriteLine("자식 걷다..");
    }
}
