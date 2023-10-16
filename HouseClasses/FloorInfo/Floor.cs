using HouseClasses.FloorInfo.RoomInfo;

namespace HouseClasses.FloorInfo
{
    public class Floor
    {
        public Dictionary<uint, IRoom> Rooms { get; set; } = new ();

        public void AddRoom(uint id, IRoom room)
        {
            Rooms.Add(id, room);
        }

        public void RemoveRoom(uint id) 
        {
            Rooms.Remove(id);
        }
    }
}
