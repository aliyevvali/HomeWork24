using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask1.Models
{
    class Hotel
    {
        public string Name { get; set; }
        public Room[] rooms = new Room[0];

        public Hotel(string name)
        {
            Name = name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }

        public void MakeReservation(int? roomId)
        {
            
            if (!(roomId == null))
            {
                foreach (Room room in rooms)
                {

                    if (room.Id == roomId)
                    {
                        if (room.IsAvailable)
                        {
                            room.IsAvailable = false;
                            
                        }
                        else
                        {
                            throw new Exception("Otaq Doludur!");                           
                        }
                     
                    }
                    else
                    {
                        throw new Exception();
                        
                    }
                }
            }
            else throw new Exception();
        }
    }
 }
