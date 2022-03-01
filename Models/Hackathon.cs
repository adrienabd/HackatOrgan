using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Hackathon
    {
        public Hackathon()
        {
            Evenements = new HashSet<Evenement>();
            Participations = new HashSet<Participation>();
        }

        public int IdHackathon { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? HeureDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public DateTime? HeureFin { get; set; }
        public string Lieu { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }
        public string Theme { get; set; }
        public DateTime? DateLimite { get; set; }
        public int? NbPlaces { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Evenement> Evenements { get; set; }
        public virtual ICollection<Participation> Participations { get; set; }
    }
}
