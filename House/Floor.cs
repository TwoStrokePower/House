using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Floor
    {
        private Dictionary<uint, Flat> flats = new Dictionary<uint, Flat>();

        public Floor() { }

        public void AddFlat(uint numberFlat, string typeRoom)
        {
            Flat flat = new Flat();
            flats[numberFlat] = flat;
            flats[numberFlat].SetTypeRoom(typeRoom);
        }

        public void ShowFlats() 
        {
            foreach (var item in flats) 
            {
                Console.WriteLine($"Квартира №{item.Key}");
            }
        }

        public void GetTypeFlat(uint numberFlat)
        {
            flats[numberFlat].GetTypeRoom();
        }
    }
}
