using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication8
{
    /// <summary>
    /// родительский класс проживание
    /// </summary>
    abstract public class Accomodation
    {
        /// <summary>
        /// стоимость
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// минимальная длительность аренды
        /// </summary>
        public int MinRent { get; set; }

        /// <summary>
        /// макс длительность аренды
        /// </summary>
        public int MaxRent { get; set; }

        /// <summary>
        /// Необхододим аванс
        /// </summary>
        public bool Prepayment { get; set; }

        private bool InRoom { get; set; }
        

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="price"></param>
        /// <param name="minRent"></param>
        /// <param name="maxRent"></param>
        /// <param name="prepayment"></param>
        public Accomodation(int price, int minRent, int maxRent, bool prepayment)
        {
            Price = price;
            MinRent = minRent;
            MaxRent = maxRent;
            Prepayment = prepayment;
        }

        /// <summary>
        /// метод заселение
        /// </summary>
        public void PeopleInRoom()
        {
            if (InRoom)
            {
                InRoom = false;
                Console.Write("В номере живет человек");
            }
            else
            {
                InRoom = true;
                Console.WriteLine("Человека заселили в номер");
            }
        }

        /// <summary>
        /// метод выселение
        /// </summary>
        public void PeopleOutRoom()
        {
            if (InRoom)
            {
                Console.WriteLine("Человека выселили из номера");
                InRoom = false;
            }
            else
            {
                InRoom = true;
                Console.WriteLine("В номере никого нет");
            }
        }
    }
}
