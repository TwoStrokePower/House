using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House.IRoom
{
     interface IRoom
    {
        bool IsThereWindow();
        bool IsThereKitchen();

        bool IsThereWater();

    }
}
