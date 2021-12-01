using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class RightTriangle: Triangle
    {
        public RightTriangle(int sideOne, int sideTwo, int hypothesis) : base(sideOne,sideTwo,hypothesis)
        {
            if (AngleOneTwo == 90)
            {
                Print();
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}