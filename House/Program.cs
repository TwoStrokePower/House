using System;
using HouseBuilder;
using Db;
using System.Collections.Generic;
using System.Linq;
namespace House
{
    public class Program
    {
        public static void Main()
        {

            HouseContext db = new HouseContext();

            foreach (var house in db.Houses)
            {
                Console.WriteLine(house.GetFullInfo());
            }

            //var newHouse = HouseBuilderClass.GenerateNewHouse("Здание № 1");
            //newHouse.AddNewFloor(-1);
            //newHouse.Floors[-1].AddNewRoom(001, "flatroom");
            //Console.WriteLine(newHouse.GetFullInfo());
            //db.Houses.Add(newHouse);
            //db.Save();

            Console.ReadKey();

        }
    }
}
