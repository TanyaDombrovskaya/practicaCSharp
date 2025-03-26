namespace HotelNamespace
{
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public string GuestName { get; set; }

        public HotelRoom(int roomNumber, string guestName)
        {
            RoomNumber = roomNumber;
            GuestName = guestName;
        }

        public override string ToString()
        {
            return $"Комната {RoomNumber}: {GuestName}";
        }
    }
}
