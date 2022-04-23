using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Room
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        private double _price;
        public double Price { get => _price;
            set
            {
                if (value>0)
                {
                    _price = value;
                }
            }
        }
        private byte _personCapacity;
        public byte PersonCapacity { get => _personCapacity;
            set
            {
                if (value>0 && value<=100)
                {
                    _personCapacity = value;
                }
            }
             
        }
        public bool IsAvailable { get; set; } = true;
        public Room(string name,double price,byte capacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = capacity;
        }
        public override string ToString()
        {
           return $"Id: {Id} Name: {Name} Price: {Price} PersonCapacity: {PersonCapacity} IsAvaiable: {IsAvailable}"; 

        }
    }
}
