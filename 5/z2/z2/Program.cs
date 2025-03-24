using CinemaNamespace;
using Bogus;
using System;

class Task2
{
    static void Main()
    {
        Distributor distributor1 = new Distributor("КиноДистрибьютор 1");
        Distributor distributor2 = new Distributor("КиноДистрибьютор 2");

        var faker = new Faker();
        Movie[] moviesForCinema1 = new Movie[3];
        Movie[] moviesForCinema2 = new Movie[3];

        for (int i = 0; i < 3; i++)
        {
            moviesForCinema1[i] = new Movie(
                faker.Commerce.ProductName(), 
                faker.PickRandom(new[] { "Комедия", "Боевик", "Драма", "Фантастика" }) 
            );

            moviesForCinema2[i] = new Movie(
                faker.Commerce.ProductName(), 
                faker.PickRandom(new[] { "Ужасы", "Триллер", "Фэнтези", "Мелодрама" }) 
            );
        }

        Cinema[] cinemas = {
            new Cinema("Кинотеатр 1", new[] { "12:00", "15:00", "18:00" }, distributor1),
            new Cinema("Кинотеатр 2", new[] { "13:00", "16:00", "19:00" }, distributor2)
        };

        distributor1.DeliverMovies(cinemas[0], moviesForCinema1);
        distributor2.DeliverMovies(cinemas[1], moviesForCinema2);

        foreach (Cinema cinema in cinemas)
        {
            cinema.ShowMovies();
            Console.WriteLine();
        }
    }
}
