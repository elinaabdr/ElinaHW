using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        public static void Main(string[] args)
        {
            var triangle = new Triangle(3, 4, 5);
            
            triangle.Square();
            triangle.Perimeter();
            triangle.Print();

            var right = new RightTriangle(3,3,3);

            var iso = new IsoscelesTriangle(3, 3, 3,1);
        }
    }
}