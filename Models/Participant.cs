using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Participant
    {
        public Participant()
        {
            Participations = new HashSet<Participation>();
        }

        public int IdParticipant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public int? Téléphone { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public string LienPortfolio { get; set; }
        public string Mdp { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }
    }
}
