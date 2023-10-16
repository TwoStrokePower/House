namespace HouseClasses.FloorInfo.RoomInfo
{
    public class StudioRoom : IRoom
    {
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
