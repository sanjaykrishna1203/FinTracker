using System;
using System.Collections.Generic;

#nullable disable

namespace FinTracker.Dal.Entity
{
    public partial class Debit
    {
        public int Id { get; set; }
        public string Narration { get; set; }
        public double TotalAmount { get; set; }
        public double Interest { get; set; }
        public DateTime LoanStartDate { get; set; }
        public DateTime LoanEndDate { get; set; }
        public double CurrentOutstanding { get; set; }
        public double Emi { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int UserRefId { get; set; }

        public virtual User UserRef { get; set; }
    }
}
