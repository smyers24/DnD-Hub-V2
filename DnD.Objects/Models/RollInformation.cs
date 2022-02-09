using DnD.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DnD.Models.Models
{
    public class RollInformation
    {
        public int? NumberOfDice { get; set; }

        public int? DieValue { get; set; }

        public int? Modifier { get; set; }

        // Rolls are, more often than not, positive. So defaulting to true
        public bool IsPositive { get; set; } = true;

        public Vantage Vantage { get; set; } = Vantage.Flat;
    }
}
