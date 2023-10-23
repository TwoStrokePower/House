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
            //Подключаемся к БД
            HouseContext db = new HouseContext();

            //Выводим список всех домов
            foreach (var house in db.Houses)
            {
                Console.WriteLine(house.GetFullInfo());
            }

            //Получаем номер последнего дома и генерируем новый номер
            var lastHouse = new List<HouseClasses.House>(db.Houses).LastOrDefault();
            var houseName = "Здание № 1";
            if (lastHouse != null)
            {
                var tmp = lastHouse.Address.Substring("Здание № ".Length);
                var id = Int32.Parse(tmp);
                id++;
                houseName = $"Здание № {id}";
            }

            //Генерируем новый дом
            var newHouse = HouseBuilderClass.GenerateNewHouse(houseName);
            newHouse.AddNewFloor(-1);
            newHouse.Floors[-1].AddNewRoom(001, "flatroom");
            Console.WriteLine(newHouse.GetFullInfo());
            
            //Добавляем новый дом в БД
            db.Houses.Add(newHouse);
            //Сохраняем изменения
            db.Save();

            Console.ReadKey();

        }
    }
}
