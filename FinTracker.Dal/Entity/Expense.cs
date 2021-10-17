using System;
using System.Collections.Generic;

#nullable disable

namespace FinTracker.Dal.Entity
{
    public partial class Expense
    {
        public int Id { get; set; }
        public int UserRefId { get; set; }
        public double ExpenseAmount { get; set; }
        public string ExpenseNarration { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ExpenseDate { get; set; }

        public virtual User UserRef { get; set; }
    }
}
