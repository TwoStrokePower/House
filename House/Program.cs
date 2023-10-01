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
            House building_1 = new House("Здание №1", 10, 4, "Красный", "Кирпич");
            building_1.Show();
            building_1.SetFlatSquare(10, 50.7);
            building_1.GetFlatSquare(10);
            building_1.WhichFloor(10);
            

            Console.ReadKey();
        }
    }
}
