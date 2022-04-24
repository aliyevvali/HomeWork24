using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask1.Models
{
    public class Room
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        private Room()
        {
            _id++;
            Id = _id;
        }

        public Room(string name,double price,int personCapacity):this()
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        

        public virtual String ShowInfo()
        {
            return $@"Id : {Id}
Name : {Name}
Price : {Price}
Person Capacity : {PersonCapacity}
Is Available : {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
