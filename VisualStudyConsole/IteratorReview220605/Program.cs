using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorReview220605
{
    public class Language
    {
        private string[] languages;

        public Language(int length)
        {
            languages = new string[length];
        }

        public int Length
        {
            get { return this.languages.Length;  }
        }

        public string this[int index]
        {
            get { return languages[index];  }
            set { if (index < Length) languages[index] = value; }
        }
        public IEnumerable<string> GetString()
        {
            List<string> temp = new List<string>();
            foreach (var get in languages)
            {
                temp.Add(get);
                
            }
            return temp;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return languages[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Language language = new Language(5);
            language[0] = "1번";
            language[1] = "2번";
            language[2] = "3번";
            language[3] = "5번";

            foreach(var lan in language.GetString())
            {
                Console.WriteLine(lan);
            }
        }
    }
}
