using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Evenement
    {
        public Evenement()
        {
            Participations = new HashSet<Participation>();
        }

        public int IdEvenement { get; set; }
        public string Theme { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan HeureDebut { get; set; }
        public TimeSpan HeureFin { get; set; }
        public int IdHackathon { get; set; }
        public int IdTypeEvenement { get; set; }

        public virtual Hackathon IdHackathonNavigation { get; set; }
        public virtual TypeEvenement IdTypeEvenementNavigation { get; set; }
        public virtual ICollection<Participation> Participations { get; set; }
    }
}
