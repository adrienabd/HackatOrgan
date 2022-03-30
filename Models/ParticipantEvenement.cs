using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Participantevenement
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public int IdEvenement { get; set; }

        public virtual Evenement IdEvenementNavigation { get; set; }
    }
}
