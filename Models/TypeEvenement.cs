using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Typeevenement
    {
        public Typeevenement()
        {
            Evenements = new HashSet<Evenement>();
        }

        public int IdType { get; set; }
        public string NomType { get; set; }

        public virtual ICollection<Evenement> Evenements { get; set; }
    }
}
