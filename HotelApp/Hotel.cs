using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms = new Room[0];
        public Hotel(string name)
        {
            Name = name;
        }
        
        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }
        public Room[] GetRooms()
        {
            return Rooms;
        }
        public void MakeReservation(int roomid)
        {
            foreach (var item in Rooms)
            {
                if (item.Id == roomid)
                {
                    if (item.IsAvailable)
                    {
                        item.IsAvailable = false;
                        Console.WriteLine("Otaq rezerv olundu");
                    }
                    else
                    {
                        Console.WriteLine("Room is Full");
                    }
                }
            }

        }
    }
}
