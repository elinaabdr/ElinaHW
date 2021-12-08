using System;
using System.Security.Policy;

namespace ConsoleApplication8.HomeWork.HomeWork_08_12_2021
{
    
    class ComplexNumber: ICloneable
    {
        private double Real { get; set; }
        private double Image { get; set; }
        
        public ComplexNumber()
        {
            Real = 0;
            Image = 0;
        }
        public ComplexNumber(double real,double image)
        {
            Real = real;
            Image = image;
        }

        public Object Clone()
        {
            return new ComplexNumber(this.Real, this.Image);
        }

        public void Add2(ComplexNumber complexNumber2)
        {
            Real = Real + complexNumber2.Real;
            Image = Image + complexNumber2.Image;
        }
        public ComplexNumber Sub(ComplexNumber complexNumber2)
        {
            ComplexNumber s = new ComplexNumber(Real-complexNumber2.Real,Image-complexNumber2.Image);
            return s;
        }
        public void Sub2(ComplexNumber complexNumber2)
        {
            Real = Real - complexNumber2.Real;
            Image = Image - complexNumber2.Image;
        }
        public ComplexNumber MultNumber(double realNumber2 = 2)
        {
            ComplexNumber s = new ComplexNumber(Real*realNumber2,Image*realNumber2);
            return s;
        }
        public void MultNumber2(double realNumber2 = 2)
        {
            Real = Real * realNumber2;
            Image = Image * realNumber2;
        }
        public ComplexNumber Mult(ComplexNumber complexNumber2)
        {
            ComplexNumber s = new ComplexNumber(Real*complexNumber2.Real-Image*complexNumber2.Image,Image*complexNumber2.Real+Real*complexNumber2.Image);
            return s;
        }
        public void Mult2(ComplexNumber complexNumber2)
        {
            Real = Real * complexNumber2.Real;
            Image = Image * complexNumber2.Image;
            Console.WriteLine(Real+Image);
        }
        public ComplexNumber Div(ComplexNumber complexNumber2)
        {
            ComplexNumber s = new ComplexNumber((Real*complexNumber2.Real+Image*complexNumber2.Image)/(complexNumber2.Real*complexNumber2.Real+complexNumber2.Image*complexNumber2.Image),(Image*complexNumber2.Real-Real*complexNumber2.Image)/(complexNumber2.Real * complexNumber2.Real + complexNumber2.Image * complexNumber2.Image));
            return s;
        }
        public double Length()
        {
            double length = Math.Sqrt(Real*Real+Image*Image);
            return length;
        }
        public string Tostring()
        {
            return $"{Real}+{Image}*i";
        }
    }

}