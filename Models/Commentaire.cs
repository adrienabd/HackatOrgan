using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Commentaire
    {
        public int IdCommentaire { get; set; }
        public string Texte { get; set; }
        public DateTime Date { get; set; }
        public int IdHackathon { get; set; }
    }
}
