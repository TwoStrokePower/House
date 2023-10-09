using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.IRoom
{
    class WorkRoom : IRoom
    {
        public bool IsThereWindow()
        {
            return false;
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
