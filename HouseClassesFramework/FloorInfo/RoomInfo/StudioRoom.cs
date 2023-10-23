using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseClasses.FloorInfo.RoomInfo
{
    [Table("StudioRooms")]
    public class StudioRoom : IRoom
    {
        [Key]
        public long Id { get ; set ; }

        public string GetInfo()
        {
            return "Помещение типа студии";
        }

        public bool IsHasKitchen()
        {
            return false;
        }

        public bool IsHasWindow()
        {
            return true;
        }
    }
}
