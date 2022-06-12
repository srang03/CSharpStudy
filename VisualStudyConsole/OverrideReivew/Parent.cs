using System;

namespace OverrideReivew
{
    public class Parent
    {
        public virtual void Say() =>  Console.WriteLine("부모 안녕하세요");
        public virtual void Run() => Console.WriteLine("부모 달리다.");
        public virtual void Walk() => Console.WriteLine("부모 걷다..");
    }
}
