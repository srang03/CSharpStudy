using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Korea.Seoul;

// 별칭 사용하여 네임스페이스 추가 가능
using BS = Korea.Busan;

namespace NameSpaceDescription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Korea.Seoul.City seoul = new Korea.Seoul.City();
            Korea.Busan.City busan = new Korea.Busan.City();

            seoul.name();
            busan.name();

            City seoul2 = new City();
            BS.City busan2 = new BS.City();

            seoul2.name();
            busan2.name();

        }
    }
}
