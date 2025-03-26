using HotelNamespace;

class Task1
{
    static void Main()
    {
        HotelReservationSystem reservationSystem = new HotelReservationSystem();

        reservationSystem.AddReservation(101, "John");
        reservationSystem.AddReservation(102, "Jane");
        reservationSystem.AddReservation(103, "Bob");

        Console.Write("Введите номер комнаты: ");
        int roomNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите имя гостя: ");
        string guestName = Console.ReadLine();

        reservationSystem.AddReservation(roomNumber, guestName);

        Console.WriteLine("\nСписок забронированных комнат:");
        reservationSystem.ListReservations();

        Console.WriteLine("\nКомната 102:");
        HotelRoom room = reservationSystem.FindReservation(102);
        if (room != null)
        {
            Console.WriteLine(room);
        }

        Console.WriteLine("\nУдаление брони комнаты 101:");
        reservationSystem.RemoveReservation(101);

        Console.WriteLine("\nОбновленный список брони:");
        reservationSystem.ListReservations();

        Console.WriteLine("\nОтсортированный список:");
        reservationSystem.SortedReservations();
    }
}
