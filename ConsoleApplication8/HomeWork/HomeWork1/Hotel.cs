using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication8
{
    public class Hotel : Accomodation
    {
        /// <summary>
        /// номер комнаты
        /// </summary>
        public int RoomNumb { get; set; }
        /// <summary>
        /// тип комнаты
        /// </summary>
        public TypeOfRoom TypeOfRoom { get; set; }
        /// <summary>
        /// тип питания
        /// </summary>
        public TypeOfFood TypeOfFood { get; set; }
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="roomNumb"></param>
        /// <param name="typeOfRoom"></param>
        /// <param name="typeOfFood"></param>
        /// <param name="price"></param>
        /// <param name="minRent"></param>
        /// <param name="maxRent"></param>
        /// <param name="prepayment"></param>
        public Hotel(int roomNumb, TypeOfRoom typeOfRoom, TypeOfFood typeOfFood,
            int price, int minRent, int maxRent, bool prepayment) : base(price, minRent, maxRent, prepayment)
        {
            RoomNumb = roomNumb;
            TypeOfRoom = typeOfRoom;
            TypeOfFood = typeOfFood;
        }

        public void HotelInfo()
        {
            Console.WriteLine("Информация о проживании:");
            Console.WriteLine($"Номер комнаты: {RoomNumb}\n " +
                              $"Тип комнаты: {TypeOfRoom}\n" +
                              $"Тип питания: {TypeOfFood}\n");
            Console.WriteLine($"Стоимость проживания: {Price}\n" +
                              $"Минимальная длительность аренды: {MinRent}\n" +
                              $"Максимальная длительность аренды: {MaxRent}\n" +
                              $"Необходимость аванса: {Prepayment}");
        }
    }

    public enum TypeOfRoom
    {
        SingleApart,
        DoubleApart,
        FamilyApart
    }

    public enum TypeOfFood
    {
        Breakfast,
        FullDay
    }
}