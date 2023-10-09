using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        private string address;
        private string material;
        private string color;
        private  Dictionary<uint, Floor> floors = new Dictionary<uint, Floor>();
        public House()
        {

        }
        public House(string address, string color, string material)
        {
            this.address = address;
            this.material = material;
        }

        public string Material
        {
            set { this.material = value; }
            get { return material; }
        }
        public string Color
        {
            set { this.Color = value; }
            get { return color; }
        }

        public void MakeFloor(uint number)
        {
             Floor floor = new Floor();
            floors.Add(number, floor);
        }

        public void MakeFlatOnFloor(uint numberFloor, uint numberFlat, string typeRoom )
        {
            floors[numberFloor].AddFlat(numberFlat, typeRoom);
        }

        public void GetTypeFlat(uint numberFloor, uint numberFlat)
        {
            floors[numberFloor].GetTypeFlat(numberFlat);
        }
        public void ShowFlatsOnFloor(uint numberFloor)
        {
            //flats = floors[numberFloor];
            //foreach (var flats in floors[numberFloor].)
            floors[numberFloor].ShowFlats();
        }
        
        public void GetFloors()
        {
            var sortedFloors = from entry in floors orderby entry.Key ascending select entry;
            foreach (var item in floors)
            {
                Console.WriteLine($"Этаж №{item.Key}");
            }

        }

        public void Show()
        {
            Console.WriteLine(address);
            Console.WriteLine(material);
            Console.WriteLine(color);
        }
    }
}
