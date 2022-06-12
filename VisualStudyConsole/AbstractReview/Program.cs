using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(20);
            System.Console.WriteLine(square.GetArea());
        }
    }
    
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Square : Shape
    {
        private int _size;
        public Square(int size)
        {
            this._size = size;
        }

        public override double GetArea()
        {
            return this._size * this._size;
        }
    }
}
