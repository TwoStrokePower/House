namespace HouseClasses.FloorInfo.RoomInfo
{
    public class StudioRoom : IRoom
    {
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
