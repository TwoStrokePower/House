using House.IRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Flat 
    {
        object type;
        
        public void SetTypeRoom(string typeRoom)
        {
            if (typeRoom == "FlatRoom")
            {
                FlatRoom room = new FlatRoom();
                type = room;
            }
            else if (true)
            {
                Console.WriteLine("kk");
            }
        }

        public void GetTypeRoom()
        {
            
        }
    }
}
