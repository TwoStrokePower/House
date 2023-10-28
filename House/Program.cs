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
            string yourString;


            switch (Console.ReadLine())
            {
                case "show houses":
                    foreach (var house in db.Houses)
                    {
                        Console.WriteLine(house.GetFullInfo());
                    }
                    break;
                case "add house":
                    Console.WriteLine("Напишите номер создаваемого дома");
                    yourString = Console.ReadLine();
                    if (uint.TryParse(yourString, out uint numberHouse))
                    {
                        var newHouse = HouseBuilderClass.GenerateNewHouse($"Здание №{numberHouse}");
                        db.Houses.Add(newHouse);
                        db.Save();
                        Console.WriteLine("Здание добавлено");
                    }
                    else
                    {
                        Console.WriteLine("Введенное значение не является числом");
                    }

                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
            //var newHouse = HouseBuilderClass.GenerateNewHouse("Здание № 2");
            //newHouse.AddNewFloor(-1);
            //newHouse.Floors[-1].AddNewRoom(001, "flatroom");
            ////Console.WriteLine(newHouse.GetFullInfo());
            //db.Houses.Add(newHouse);
            //db.Save();
            //Console.WriteLine("Объект сохранен");
            Console.Write("Press any key to close app...");
            Console.ReadKey();

        }
    }
}
