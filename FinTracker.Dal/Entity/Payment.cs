using System;
using System.Collections.Generic;

#nullable disable

namespace FinTracker.Dal.Entity
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int DebitRefId { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int UserRefId { get; set; }

        public virtual User UserRef { get; set; }
    }
}
