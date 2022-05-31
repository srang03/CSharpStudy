using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignBaseSignRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var signs = new SignContext().Signs;

            foreach(var sign in signs)
            {
                Console.WriteLine($"{sign.SignId}, {sign.Email}, {sign.Password}");
            }
        }
    }

    /// <summary>
    ///  모델 클래스
    /// </summary>
    public class SignBase
    {
        public SignBase(int signId, string email, string password)
        {
            this.SignId = signId;
            this.Email = email;
            this.Password = password;
        }
        public int SignId { get; set; }
        public string Email { get; set; }
        public string Password { get; set;  }
    }

    /// <summary>
    /// 리포지토리 클래스
    /// </summary>
    /// 
    public class SignRepository
    {
        public List<SignBase> GetAll()
        {
            var signs = new List<SignBase>()
            {
                new SignBase(1, "a@a.com", "1234"),
                new SignBase(2, "b@b.com", "4567"),
                new SignBase(3, "b@b.com", "8912")
            };
            return signs;
        }
    }

    /// <summary>
    /// 컨텍스트 클래스
    /// </summary>
    public class SignContext
    {
        public List<SignBase> Signs
        {
            get { return new SignRepository().GetAll(); }
        }
    }
}
