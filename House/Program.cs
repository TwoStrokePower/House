using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        string adress;
        int count_floor;
        string material;
        string color;
        int count_flat;
        int count_flat_on_floor;
        double[] flats;
        void InitializeHouse()
        {
            
        }
        public House(string adress, int count_floor, int count_flat_on_floor, string color, string material) 
        {
            this.adress = adress;
            this.count_floor = count_floor;
            this.count_flat_on_floor = count_flat_on_floor;
            this.count_flat = count_floor*count_flat_on_floor;
            this.flats = new double[count_flat];
            this.color = color;
            this.material = material;
            InitializeHouse();
        }
        public int Count_floor
        {
            set {count_floor = value;} get {return count_floor;}
        }

        public string Material
        {
            set {this.material = value; } get {return material;}
        }
        public string Color
        {
            set { this.Color = value; }
            get { return color; }
        }

        public void Set_flat_square (int number, double square)
        {
            flats[number-1] = square;
        }

        public void Get_flat_square(int number)
        {
            Console.WriteLine(flats[number - 1]);
        }

        public void Which_floor(int number)
        {
            int floor;
            if (number%count_flat_on_floor != 0)
            {
                
                floor = number / count_flat_on_floor + 1;
            }
            else
            {
                floor = number / count_flat_on_floor;
            }
            Console.WriteLine(floor);
        }
        public void Show()
        {
            Console.WriteLine(adress);
            Console.WriteLine(count_floor);
            Console.WriteLine(count_flat);
            Console.WriteLine(material);
            Console.WriteLine(color);
        }
    }

    internal class Program
    {
        static void Main()
        {
            House building_1 = new House("Здание №1", 10, 4, "Красный", "Кирпич");
            building_1.Show();
            building_1.Set_flat_square(10, 50.6);
            building_1.Get_flat_square(10);
            building_1.Which_floor(10);
            

            Console.ReadKey();
        }
    }
}
