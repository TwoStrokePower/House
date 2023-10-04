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
        private  Dictionary<int, Floor> floors = new Dictionary<int, Floor>();
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

        public void MakeFloor(int number)
        {
             Floor floor = new Floor();
            floors.Add(number, floor);
        }

        public void MakeFlatOnFloor(int number)
        {
            
        }

        public void Show()
        {
            Console.WriteLine(address);
            Console.WriteLine(material);
            Console.WriteLine(color);
        }
    }
}
