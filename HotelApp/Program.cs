using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //double price1;
            //byte capacity1;
            double price;
            byte capacity;
            do
            {
                Console.WriteLine("Capacity daxil edin");
                capacity = Convert.ToByte(Console.ReadLine());
            } while (capacity < 0 || capacity>100);
            do
            {
                Console.WriteLine("Price daxil edin");
                price = Convert.ToDouble(Console.ReadLine());
            } while (price < 0);
            //Console.WriteLine("2ci otaq: ");
            //do
            //{
            //    Console.WriteLine("Capacity daxil edin");
            //    capacity1 = Convert.ToByte(Console.ReadLine());
            //} while (capacity1 < 0 || capacity1 > 100);
            //do
            //{
            //    Console.WriteLine("Price daxil edin");
            //    price1 = Convert.ToDouble(Console.ReadLine());
            //} while (price1 < 0);
            Room room = new Room("Otaq-1", price, capacity);
            //Room room1 = new Room("Otaq-2", price1, capacity1)
            Hotel hotel = new Hotel("Hotel-1");
            Console.WriteLine("IsAvaible y/n");
            string isavaiable = Console.ReadLine();

            if (isavaiable == "y")
            {
                room.IsAvailable = true;
            }
            else
            {
                room.IsAvailable = false;
            }
            Console.WriteLine(room.ToString());

            Room[] rooms = { room /*,room1*/};
            foreach (var item in rooms)
            {
                Console.WriteLine("Array: \n");
                Console.WriteLine(item);
            }


        }
    }
}
