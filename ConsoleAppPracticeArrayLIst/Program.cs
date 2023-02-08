using ConsoleAppPracticeArrayLIst.Models.Enums;
using ConsoleAppPracticeArrayLIst.Models;
using ConsoleAppPracticeArrayLIst.Services;

namespace ConsoleAppPracticeArrayLIst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sirius = new Hall
            {
                Id = 1,
                Name = "Srius",
                RowCount = 10,
                ColumnCount = 12
            };

            var canopus = new Hall
            {
                Id = 2,
                Name = "Mercuri",
                RowCount = 6,
                ColumnCount = 6
            };

            var arcturus = new Hall
            {
                Id = 3,
                Name = "Yupiter",
                RowCount = 6,
                ColumnCount = 6
            };

            var cinemaPlus = new Cinema
            {
                Id = 1,
                Name = "GabalaCityCinema",
                Halls = new List<Hall> { sirius, canopus }
            };

            var nizamiKino = new Cinema
            {
                Id = 2,
                Name = "GabalaNationalCinemaCenter",
                Halls = new List<Hall> { arcturus }
            };

            var filmSeven = new Film
            {
                Id = 1,
                Name = "Seven",
                Director = "Nolan",
                TimeInMinute = 95
            };

            var filmZodiac = new Film
            {
                Id = 2,
                Name = "Zodiac",
                Director = "Nolan",
                TimeInMinute = 135
            };

            var sessionSeven = new Session
            {
                Id = 1,
                Film = filmSeven,
                Hall = sirius,
                Seats = new State[sirius.RowCount, sirius.ColumnCount],
                Price = 15,
                CinemaId = 1,
                Cinema = cinemaPlus,
            };

            var sessionZodiac = new Session
            {
                Id = 2,
                Film = filmZodiac,
                Hall = canopus,
                Seats = new State[canopus.RowCount, canopus.ColumnCount],
                Price = 10,
                CinemaId = 2,
                Cinema = nizamiKino
            };

            var cinemaManager = new CinemaManager();
            cinemaManager.Add(cinemaPlus);
            cinemaManager.Add(nizamiKino);

            var sessionManager = new SessionManager();
            sessionManager.Add(sessionZodiac);
            sessionManager.Add(sessionSeven);

            var filmManager = new FilmManager();
            filmManager.Add(filmZodiac);
            filmManager.Add(filmSeven);

            var hallManager = new HallManager();
            hallManager.Add(canopus);
            hallManager.Add(sirius);
            hallManager.Add(arcturus);



            var ticketManager = new TicketManager(sessionManager, cinemaManager);

            string command;

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command == "buy ticket")
                    ticketManager.BuyTicket();
                else if (command == "show tickets")
                    ticketManager.Print();
                else if (command == "show films")
                    filmManager.Print();
                else if (command == "show halls")
                    hallManager.Print();


            } while (command != "quit");
        }
    }
}