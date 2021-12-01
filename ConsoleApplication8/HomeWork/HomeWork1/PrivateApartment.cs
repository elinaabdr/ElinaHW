using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication8
{
    public class PrivateApartment: Accomodation
    {
        /// <summary>
        /// полное жилье/только комната
        /// </summary>
        public FullNotFull FullOrOneRoom { get; set; }
        /// <summary>
        /// оплачена ли уборка
        /// </summary>
        public bool Cleaning { get; set; }
        /// <summary>
        /// оплачены ли ключи
        /// </summary>
        public bool Key { get; set; }
        /// <summary>
        /// оплачен ли интернет
        /// </summary>
        public bool Internet { get; set; }

        public PrivateApartment(FullNotFull fullOrOneRoom, bool cleaning, bool key, bool internet,
            int price, int minRent, int maxRent, bool prepayment) : base(price, minRent, maxRent, prepayment)
        {
            FullOrOneRoom = fullOrOneRoom;
            Cleaning = cleaning;
            Key = key;
            Internet = internet;
        }

        public void PrivateApartInfo()
        {
            Console.WriteLine($"Вместимость жилья: {FullOrOneRoom} \n" +
                              $"Оплачены ли ключи: {Key}\n" +
                              $"Оплачен ли интернет: {Internet}");
        }
    }

    public enum FullNotFull
    {
        Full, 
        OneRoom
    }
}