using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonClass btn = new ButtonClass();

            // [4] 객체 Click 이벤트에 실행할 메서드 등록
            btn.Click += Btn_Click;
            btn.OnClick();

        }

        private static void Btn_Click()
        {
            Console.WriteLine("버튼이 클릭되었습니다.");
        }
    }

    public class ButtonClass
    {
        // [1] 이벤트 생성을 위한 대리자 하나 생성
        public delegate void EventHandler();

        // [2] 이벤트 선언 : Click 이벤트
        public event EventHandler Click;

        // [3] 이벤트 발생 메서드 : OnClick 이벤트 처리기 (이벤트 핸들러) 생성
        public void OnClick()
        {
            if(Click != null)
            {
                Click(); // 대리자 형식의 이벤트 수행
            }
        }
    }
}
