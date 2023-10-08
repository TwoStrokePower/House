using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    

    internal class Program
    {
        static void Main()
        {
            House building_1 = new House("Здание №1", "Красный", "Кирпич");
            building_1.Show();
            building_1.MakeFloor(2);
            building_1.MakeFlatOnFloor(2, 10);
            building_1.MakeFlatOnFloor(2, 11);
            building_1.ShowFlatsOnFloor(2);
            building_1.MakeFloor(3);
            building_1.GetFloors();




            Console.ReadKey();
        }
    }
}
