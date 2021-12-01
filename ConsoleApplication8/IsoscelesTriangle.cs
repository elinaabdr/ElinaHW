using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class IsoscelesTriangle: Triangle
    {
        public int Height { get; set; }
        
        public IsoscelesTriangle( int sideOne, int sideTwo, int sideThree,int height) : base(sideOne, sideTwo, sideThree)
        {
            Height = height;
            if (sideOne == sideTwo || sideTwo == sideThree || sideThree == SideOne)
            {
                Print();
            }
            else
            {
                Console.WriteLine("Треугольник не рб");
            }
        }

        public void Square(int height,int sideOne)
        {
            double square = 0.5 * height * sideOne;
            Console.WriteLine((square));
        }
    }
}