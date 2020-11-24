using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS322_Vezba8_BojanPetrovic2745.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int MinimumPlayers { get; set; }
        public int MaximumPlayers { get; set; }
    }
}
