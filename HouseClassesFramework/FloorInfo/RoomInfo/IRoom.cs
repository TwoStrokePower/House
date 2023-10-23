using System.ComponentModel.DataAnnotations;

namespace HouseClasses.FloorInfo.RoomInfo
{
    public interface IRoom
    {
        [Key]
        long Id { get; set; }
        bool IsHasWindow();
        bool IsHasKitchen();
        string GetInfo();
    }
}
