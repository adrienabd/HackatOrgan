using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Participation
    {
        public int IdParticipation { get; set; }
        public int? IdHackathon { get; set; }
        public int IdParticipant { get; set; }
        public DateTime DateInscription { get; set; }

        public virtual Hackathon IdHackathonNavigation { get; set; }
        public virtual Participant IdParticipantNavigation { get; set; }
    }
}
