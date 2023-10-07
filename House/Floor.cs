using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Floor
    {
        private Dictionary<int, Flat> flats = new Dictionary<int, Flat>();

        public Floor() { }

        public void AddFlat(int numberFloor)
        {
            Flat flat = new Flat();
            flats[numberFloor] = flat;
        }

        public void ShowFlats() 
        {
            foreach (var item in flats) 
            {
                Console.WriteLine($"Квартира №{item.Key}");
            }
        }
    }
}
