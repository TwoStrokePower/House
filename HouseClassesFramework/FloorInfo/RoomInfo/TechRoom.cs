using System.ComponentModel.DataAnnotations.Schema;

namespace HouseClasses.FloorInfo.RoomInfo
{
    [Table("TechRooms")]
    public class TechRoom : IRoom
    {
        public long Id { get; set; }

        public string GetInfo()
        {
            return "Помещение типа технической комнаты";
        }

        public bool IsHasKitchen()
        {
            return false;
        }

        public bool IsHasWindow()
        {
            return false;
        }
    }
}
