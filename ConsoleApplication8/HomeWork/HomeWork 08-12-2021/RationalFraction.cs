using System;

namespace ConsoleApplication8.HomeWork.HomeWork_08_12_2021
{
    public class RationalFraction: IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            RationalFraction compare = (RationalFraction) obj;
            if (obj != null && this != null)
            {
                if (this.CalcValue() > compare.CalcValue())
                    return 1;
                else if (this.CalcValue() < compare.CalcValue())
                    return -1;
                else
                {
                    return 0;
                }
            }
            else throw new Exception("Невозможно сравнить объекты");
        }
        
        public RationalFraction(int a, int b)
        {
            Chisl = a;
            Znam = b;
        }

        public int Chisl { get; set; }
        public int Znam { get; set; }
        public double Value;

        public double CalcValue()
        {
            Value = Chisl / Znam;
            return Value;
        }

        public RationalFraction Sum(RationalFraction fraction)
        {
            return new RationalFraction(this.Chisl * fraction.Znam + fraction.Chisl * this.Znam,
                this.Znam * fraction.Znam);
        }

        public RationalFraction Razn(RationalFraction fraction)
        {
            return new RationalFraction(this.Chisl * fraction.Znam - fraction.Chisl * this.Znam,
                this.Znam * fraction.Znam);
        }

        public RationalFraction Product(RationalFraction fraction)
        {
            return new RationalFraction(this.Chisl * fraction.Chisl,
                this.Znam * fraction.Znam);
        }

        public RationalFraction Del(RationalFraction fraction)
        {
            return new RationalFraction(this.Chisl * fraction.Znam,
                this.Znam * fraction.Chisl);
        }

        public void ToString()
        {
            Console.WriteLine($"{Chisl}/{Znam} ");
        }
    }
}

