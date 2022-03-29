using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Favori
    {
        public int IdFavori { get; set; }
        public int IdHackathon { get; set; }
        public int IdParticipant { get; set; }
    }
}
