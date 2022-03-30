using System;
using System.Collections.Generic;

#nullable disable

namespace HackatOrgan.Models
{
    public partial class Intervenantevenement
    {
        public int IdIe { get; set; }
        public int IdIntervenant { get; set; }
        public int IdEvenement { get; set; }
    }
}
