namespace HouseClasses.FloorInfo.RoomInfo
{
    public class TechRoom : IRoom
    {
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
