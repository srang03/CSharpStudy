using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonClass buttonClass = new ButtonClass();
            buttonClass.Click += () => { Console.WriteLine("버튼이 클릭되었습니다"); };
            buttonClass.OnClick();
        }
    }

    public class ButtonClass
    {
        public delegate void EventHandler();

        public event EventHandler Click;

        public void OnClick()
        {
            if(Click != null)
            {
                this.Click();
            }
        }
    }
}
