using HouseClasses.FloorInfo;
using System.Collections.Generic;
using System.Text;

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

        public string GetFullInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Дом по адресу {Address} состоит из этажей:");
            foreach (var floor in Floors)
            {
                sb.AppendLine($"{floor.Key}: {floor.Value.GetInfo()}");
            }
            return sb.ToString();
        }
    }
}