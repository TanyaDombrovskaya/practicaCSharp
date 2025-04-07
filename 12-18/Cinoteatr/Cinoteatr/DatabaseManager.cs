using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows;

namespace SQLiteExample
{
    public class DatabaseManager
    {
        private string _dbPath;

        public DatabaseManager()
        {
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cinema.db");
            CreateDatabase();
            CreateTables();
            SeedData();
        }

        private void CreateDatabase()
        {
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
            }
        }

        private void CreateTables()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string createSessionsTableQuery = @"
                CREATE TABLE IF NOT EXISTS Sessions (
                    ID_FILM INTEGER PRIMARY KEY AUTOINCREMENT,
                    FILM TEXT NOT NULL
                );";

                using (var command = new SQLiteCommand(createSessionsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createTicketsTableQuery = @"
                CREATE TABLE IF NOT EXISTS Tickets (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    TIME TEXT NOT NULL
                );";

                using (var command = new SQLiteCommand(createTicketsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Таблицы Sessions и Tickets созданы или уже существуют.");
            }
        }

        private void SeedData()
        {
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();

                string[] initialFilms = { "SuperMan", "Ambasador", "FilmFilm" };
                foreach (var film in initialFilms)
                {
                    string checkFilmExistsQuery = "SELECT COUNT(*) FROM Sessions WHERE FILM = @Film;";
                    using (var checkCommand = new SQLiteCommand(checkFilmExistsQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Film", film);
                        long count = (long)checkCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertFilmQuery = "INSERT INTO Sessions (FILM) VALUES (@Film);";
                            using (var insertCommand = new SQLiteCommand(insertFilmQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@Film", film);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }

                string[] initialTimes = { "15:00", "18:00", "21:00" };
                foreach (var time in initialTimes)
                {
                    string checkTimeExistsQuery = "SELECT COUNT(*) FROM Tickets WHERE TIME = @Time;";
                    using (var checkCommand = new SQLiteCommand(checkTimeExistsQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Time", time);
                        long count = (long)checkCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            string insertTimeQuery = "INSERT INTO Tickets (TIME) VALUES (@Time);";
                            using (var insertCommand = new SQLiteCommand(insertTimeQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@Time", time);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        // Метод для получения всех фильмов из таблицы Sessions
        public List<string> GetAllFilms()
        {
            var films = new List<string>();
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string selectQuery = "SELECT FILM FROM Sessions;";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            films.Add(reader["FILM"].ToString());
                        }
                    }
                }
            }
            return films;
        }

        // Метод для получения всех времен из таблицы Tickets
        public List<string> GetAllTimes()
        {
            var times = new List<string>();
            using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
            {
                connection.Open();
                string selectQuery = "SELECT TIME FROM Tickets;";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            times.Add(reader["TIME"].ToString());
                        }
                    }
                }
            }
            return times;
        }
        public bool CheckConnection()
        {
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={_dbPath};Version=3;"))
                {
                    connection.Open();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}