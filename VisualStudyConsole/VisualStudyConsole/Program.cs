using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudyConsole
{
    struct Score
    {
        public string Name;
        public int Kor;
        public int Eng;
        public int Total;
        public double Avg;
        public int Graph;
    }

    class struct_graph
    {
        static void Main(string[] args)
        {
            Score[] scores = new Score[3];

            scores[0].Name = "홍길동"; scores[0].Kor = 100; scores[0].Eng = 90;
            scores[1].Name = "백두산"; scores[1].Kor = 90; scores[1].Eng = 50;
            scores[2].Name = "임꺽정"; scores[2].Kor = 100; scores[2].Eng = 80;
            
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i].Total = scores[i].Kor + scores[i].Eng;
                scores[i].Avg = (double)scores[i].Total / 2;
                scores[i].Graph = (int)scores[i].Avg / 5;
            }

            Console.WriteLine("이름\t 총점\t 평균\t 막대 그래프");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0}\t {1}\t {2}\t", scores[i].Name, scores[i].Total, scores[i].Avg);
                for(int j = 0; j<scores[i].Graph; j++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}
