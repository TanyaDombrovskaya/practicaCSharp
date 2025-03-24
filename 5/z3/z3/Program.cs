using Bogus;
using TeamNamespace;

class Task3
{
    static void Main()
    {
        var faker = new Faker();

        TeamMember[] players = new TeamMember[10];
        for (int i = 0; i < players.Length; i++)
        {
            if (i % 2 == 0)
            {
                players[i] = new Basketballer(faker.Name.FullName());
            }
            else
            {
                players[i] = new Footballer(faker.Name.FullName());
            }
        }

        Console.WriteLine("Все игроки:");
        foreach (var player in players)
        {
            player.ShowInfo();
            Console.WriteLine();
        }

        Console.WriteLine("Баскетболисты:");
        foreach (var player in players)
        {
            if (player is IBasketballPlayer basketballPlayer)
            {
                basketballPlayer.PlayBasketball();
            }
        }
    }
}