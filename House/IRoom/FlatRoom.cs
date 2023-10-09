using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.IRoom
{
     class FlatRoom : IRoom
    {
        public bool IsThereWindow()
        {
            return true; 
        }

        public bool IsThereKitchen()
        {
            return true;
        }

        public bool IsThereWater()
        {
            return true;
        }
    }
}
