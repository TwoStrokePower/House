using System;
using HouseBuilder;

namespace House
{
    public class Program
    {
        public static void Main()
        {
            //House building_1 = new House("Здание №1", "Красный", "Кирпич");
            //building_1.Show();
            //building_1.MakeFloor(2);
            //building_1.MakeFlatOnFloor(2, 10, "FlatRoom");
            //building_1.MakeFlatOnFloor(2, 11, "Flat");
            //building_1.ShowFlatsOnFloor(2);
            //building_1.MakeFloor(3);
            //building_1.GetFloors();
            //building_1.GetTypeFlat(2, 10);

            var newHouse = HouseBuilderClass.GenerateNewHouse("Здание № 1");
            newHouse.AddNewFloor(-1);
            newHouse.Floors[-1].AddNewRoom(001, "flatroom");
            Console.WriteLine(newHouse.GetFullInfo());
            Console.ReadKey();
        }
    }
}
