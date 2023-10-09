namespace HouseClasses.FloorInfo.RoomInfo
{
    public class FlatRoom : IRoom
    {
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
