 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorReview
{
    class Program
    {
        static void Main(string[] args)
        {
            YieldReturn yieldReturn = new YieldReturn();
          foreach(var item in yieldReturn.MultiData())
            {
                Console.WriteLine(item);
            }

            Language language = new Language(5);
            language[0] = "KOR";
            language[1] = "ENG";

            foreach (var item in language)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Language
    {
        private string[] _languages;

        public int Length { get; private set; }
        public Language(int length)
        {
            this.Length = length;
            _languages = new string[Length];
        }

        public string this[int index]
        {
            get { return _languages[index]; }
            set { _languages[index] = value;  }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i<this.Length; i++)
            {
                yield return _languages[i];
            }
        }


    }

    class YieldReturn
    {
        public IEnumerable MultiData()
        {
            yield return "H1";
            yield return "H2";
            yield return "H3";
        }
    }
}
