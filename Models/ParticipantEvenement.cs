using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class ParticipantEvenement
    {
        public int ParticipantEvenementId { get; set; }
        public string ParticipantEvenementNom { get; set; }
        public string ParticipantEvenementPrenom { get; set; }
        public string ParticipantEvenementMail { get; set; }
        public int ParticipantEvenementEvenementId { get; set; }
    }
}
