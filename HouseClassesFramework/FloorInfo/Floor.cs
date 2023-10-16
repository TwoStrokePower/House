using HouseClasses.FloorInfo.RoomInfo;
using System.Collections.Generic;
using System.Text;

namespace HouseClasses.FloorInfo
{
    public class Floor
    {
        public Dictionary<uint, IRoom> Rooms { get; set; } = new Dictionary<uint, IRoom>();

        public void AddRoom(uint id, IRoom room)
        {
            Rooms.Add(id, room);
        }

        public void RemoveRoom(uint id) 
        {
            Rooms.Remove(id);
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var room in Rooms)
            {
                sb.AppendLine($"{room.Key}: {room.Value.GetInfo()}");
            }
            return sb.ToString();
        }
    }
}
