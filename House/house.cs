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
        //private int countFloor;
        private string material;
        private string color;
        protected Floor[] floors;
        //private int countFlat;
        //private int countFlatOnFloor;
        //private double[] flats;
        public House()
        {

        }
        public House(string address, string color, string material)
        {
            this.address = address;
            //this.countFloor = countFloor;
            //this.countFlatOnFloor = countFlatOnFloor;
            //this.countFlat = countFloor * countFlatOnFloor;
            //this.flats = new double[countFlat];
            this.color = color;
            this.material = material;
        }
        //public int CountFloor
        //{
        //    set { countFloor = value; }
        //    get { return countFloor; }
        //}

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
            floors[number] = new Floor();
        }

        //public void SetFlatSquare(int number, double square)
        //{
        //    flats[number - 1] = square;
        //}

        //public void GetFlatSquare(int number)
        //{
        //    Console.WriteLine(flats[number - 1]);
        //}

        //public void WhichFloor(int number)
        //{
        //    int floor;
        //    if (number % countFlatOnFloor != 0)
        //    {

        //        floor = number / countFlatOnFloor + 1;
        //    }
        //    else
        //    {
        //        floor = number / countFlatOnFloor;
        //    }
        //    Console.WriteLine(floor);
        //}
        public void Show()
        {
            Console.WriteLine(address);
            //Console.WriteLine(countFloor);
            //Console.WriteLine(countFlat);
            Console.WriteLine(material);
            Console.WriteLine(color);
        }
    }
}
