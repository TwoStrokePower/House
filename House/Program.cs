using System;
using HouseBuilder;
using Db;
namespace House
{
    public class Program
    {
        public static void Main()
        {

            HouseContext db = new HouseContext();
            var newHouse = HouseBuilderClass.GenerateNewHouse("Здание № 1");
            newHouse.AddNewFloor(-1);
            newHouse.Floors[-1].AddNewRoom(001, "flatroom");
            Console.WriteLine(newHouse.GetFullInfo());
            db.Houses.Add(newHouse);
            db.Save();

            Console.ReadKey();

        }
    }
}
