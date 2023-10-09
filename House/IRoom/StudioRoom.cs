using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.IRoom
{
     class StudioRoom : IRoom
    {
        public bool IsThereWindow()
        {
            return true;
        }

        public bool IsThereKitchen()
        {
            return false;
        }

        public bool IsThereWater()
        {
            return false;
        }
    }
}
