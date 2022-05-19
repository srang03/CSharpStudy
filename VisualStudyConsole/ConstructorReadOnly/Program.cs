using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file = new WhichService("[1] 파일 로그");
            file.Run();
        }
    }

    public class WhichService
    {
        private readonly string _serviceName;
        public WhichService(string serviceName)
        {
            _serviceName = serviceName;
        }

        public void Run() => Console.WriteLine($"{_serviceName} 기능 수행");
    }

}
