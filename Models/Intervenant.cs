using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Intervenant
    {
        public int IdIntervenant { get; set; }
        public int Nom { get; set; }
        public int Prenom { get; set; }
        public int Mail { get; set; }
        public int Telephone { get; set; }
    }
}
