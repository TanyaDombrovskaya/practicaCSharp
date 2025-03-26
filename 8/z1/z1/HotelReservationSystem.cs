using System.Collections;

namespace HotelNamespace
{
    public class HotelReservationSystem
    {
        private Hashtable _rooms;

        public HotelReservationSystem()
        {
            _rooms = new Hashtable();
        }

        public void AddReservation(int roomNumber, string guestName)
        {
            if (!_rooms.ContainsKey(roomNumber))
            {
                _rooms.Add(roomNumber, new HotelRoom(roomNumber, guestName));
                Console.WriteLine($"Комната {roomNumber} забронирвана {guestName}.");
            }
            else
            {
                Console.WriteLine($"Комната {roomNumber} уже забронирована.");
            }
        }

        public void RemoveReservation(int roomNumber)
        {
            if (_rooms.ContainsKey(roomNumber))
            {
                _rooms.Remove(roomNumber);
                Console.WriteLine($"Бронирование для комнаты {roomNumber} удалено.");
            }
            else
            {
                Console.WriteLine($"Комната {roomNumber} не забронирована.");
            }
        }

        public HotelRoom FindReservation(int roomNumber)
        {
            if (_rooms.ContainsKey(roomNumber))
            {
                return (HotelRoom)_rooms[roomNumber];
            }
            Console.WriteLine($"Комната {roomNumber} не забронирована.");
            return null;
        }

        public void ListReservations()
        {
            foreach (DictionaryEntry entry in _rooms)
            {
                Console.WriteLine(entry.Value);
            }
        }

        public void SortedReservations()
        {
            var sortedRooms = new SortedList();
            foreach (DictionaryEntry entry in _rooms)
            {
                sortedRooms.Add(entry.Key, entry.Value);
            }

            foreach (DictionaryEntry entry in sortedRooms)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}
