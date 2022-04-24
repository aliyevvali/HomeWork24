using HotelTask1.Models;
using System;

namespace HotelTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("1No",350,3);
            Room room2 = new Room("2No",200,4);
            Room room3 = new Room("3No",250,3);
            Room room4 = new Room("4No",800,1);
            

            Hotel hotel = new Hotel("Ali Hotel");
                       
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);
            hotel.AddRoom(room4);
            hotel.MakeReservation(2);
            
          
            foreach (var item in hotel.rooms)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
