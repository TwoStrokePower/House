using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseClasses.FloorInfo.RoomInfo
{
    [Table("FlatRooms")]
    public class FlatRoom : IRoom
    {
        [Key]
        public long Id { get; set; }

        public string GetInfo()
        {
            return "Помещение типа квартира";
        }

        public bool IsHasKitchen()
        {
            return true;
        }

        public bool IsHasWindow()
        {
            return true;
        }
    }
}
