using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_iterator
{
    public class Language
    {
        private int position;
        private string[] languages;
        public int Length { get; private set;}
        public Language(int length)
        {
            position = 0;
            this.Length = length;
            languages = new string[Length];
        }

        public string this [int index]
        {
            get { return this.languages[index]; }
            set { position++;  this.languages[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < position; i++){
                yield return languages[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var language = new Language(10);

            language[0] = "C#";
            language[1] = "ASP.NET";

            foreach(var lang in language)
            {
                
                Console.WriteLine(lang);
            }
        }
    }
}
