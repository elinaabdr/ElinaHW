using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Triangle
    {
        /// <summary>
        /// сторона 1
        /// </summary>
        public double SideOne { get; set; }
        /// <summary>
        /// сторона 2
        /// </summary>
        public double SideTwo { get; set; }
        /// <summary>
        /// сторона 3
        /// </summary>
        public double SideThree { get; set; }
        /// <summary>
        /// угол между сторонами 1 и 2
        /// </summary>
        public double AngleOneTwo { get; set; }
        /// <summary>
        /// угол между сторонами 1 и 3
        /// </summary>
        public double AngleOneThree { get; set; }
        /// <summary>
        /// угол между сторонами 3 и 2
        /// </summary>
        public double AngleTwoThree { get; set; }

        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
            
            
            AngleOneTwo = Angle(SideOne, SideTwo, SideThree);
            AngleOneThree = Angle(SideOne, SideThree, SideTwo);
            AngleTwoThree = Angle(SideThree, SideTwo, SideOne);
        }

        public double Angle(double sideA,double sideB,double sideOpposite)
        {
            
            double output = Math.Acos((sideA*sideA + sideB*sideB - sideOpposite*sideOpposite) / (2 * sideA * sideB))*(180/Math.PI);
            
            return output;
        }
        
        public void Square()
        {
            double semiperimeter = (SideOne + SideTwo + SideThree) / 2;
            double square = Math.Sqrt(semiperimeter * (semiperimeter - SideOne)
                                                 * (semiperimeter - SideTwo) * (semiperimeter - SideThree));
            Console.WriteLine($"Площадь треугольника: {square}");
        }

        public void Perimeter()
        {
            double perimeter = SideOne + SideTwo + SideThree;
            Console.WriteLine($"Периметр треугольника равен: {perimeter}");
        }

        public void Print()
        {
            Console.WriteLine($"Сторона 1: {SideOne}");
            Console.WriteLine($"Сторона 2: {SideTwo}");
            Console.WriteLine($"Сторона 3: {SideThree}");
            
            Console.WriteLine($"Угол между сторонами 1 и 2: {AngleOneTwo}");
            Console.WriteLine($"Угол между сторонами 1 и 3: {AngleOneThree}");
            Console.WriteLine($"Угол между сторонами 2 и 3: {AngleTwoThree}");
            
        }
    }
}