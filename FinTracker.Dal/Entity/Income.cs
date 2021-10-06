using System;
using System.Collections.Generic;

#nullable disable

namespace FinTracker.Dal.Entity
{
    public partial class Income
    {
        public int Id { get; set; }
        public DateTime IncomeDate { get; set; }
        public string Narration { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int UserRefId { get; set; }

        public virtual User UserRef { get; set; }
    }
}
