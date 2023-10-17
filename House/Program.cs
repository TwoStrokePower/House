using System;
using HouseBuilder;

namespace House
{
    public class Program
    {
        public static void Main()
        {

            var newHouse = HouseBuilderClass.GenerateNewHouse("Здание № 1");
            newHouse.AddNewFloor(-1);
            newHouse.Floors[-1].AddNewRoom(001, "flatroom");
            Console.WriteLine(newHouse.GetFullInfo());
            Console.ReadKey();
        }
    }
}
