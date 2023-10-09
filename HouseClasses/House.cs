using HouseClasses.FloorInfo;

namespace HouseClasses
{
    public class House
    {
        public string Address { get; set; } = "";
        public Dictionary<int, Floor> Floors { get; set; } = new Dictionary<int, Floor>();

        public House() { }

        public House(string address) 
        {
            this.Address = address;
        }

        public void AddFloor(int floorLevel, Floor floor) 
        {
            Floors.Add(floorLevel, floor);
        }

        public void RemoveFloor(int floorLevel) 
        {
            Floors.Remove(floorLevel);
        }
    }
}