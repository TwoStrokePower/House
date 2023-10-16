using HouseClasses;
using HouseClasses.FloorInfo;
using HouseClasses.FloorInfo.RoomInfo;
using System;
using System.Collections.Generic;

namespace HouseBuilder
{
    public static class HouseBuilderClass
    {
        private static Dictionary<string, Type> roomTypes = new Dictionary<string, Type>()
        {
            { "tech", typeof(TechRoom) },
            { "studio", typeof(StudioRoom) },
            { "flatroom", typeof(FlatRoom) }
        };
        public static House GenerateNewHouse(string address)
        {
            return new House(address);
        }

        public static void AddNewFloor(this House house, int floorLevel)
        {
            house.AddFloor(floorLevel, new Floor());
        }

        public static void AddNewRoom(this Floor floor, uint roomId, string roomType) 
        {
            if (roomTypes.ContainsKey(roomType))
            {
                IRoom newRoom = (IRoom)Activator.CreateInstance(roomTypes[roomType]);
                floor.AddRoom(roomId, newRoom);
            }
            else
                throw new Exception($"Не найден тип комнаты {roomType}");
        }
    }
}
