using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ConsoleAppPracticeArrayLIst.Data
{
    internal class DataContext
    {
        public static List<Film> Films { get; set; } = new();
        public static List<Cinema> Cinemas { get; set; } = new();
        public static List<Session> Sessions { get; set; } = new();
        public static List<Ticket> Tickets { get; set; } = new();
        public static List<Hall> Halls { get; set; } = new();
    }
}
