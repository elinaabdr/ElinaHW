using System;

namespace ConsoleApplication8.HomeWork.HomeWork_01_12_2021
{
    public class Decorate
    {
        public void DecorateMethod(DecorationObj decor)
        {
            if (decor.NumbOfPowerSocket >= decor.SquareOfDecor)
            {
                decor.Decor = new Lights();
                Console.WriteLine("***Украшаем объект гирляндой***");
            }
            else
            {
                decor.Decor = new Toy();
                Console.WriteLine("***Украшаем объект игрушкой***");
            }
        }
    }
}