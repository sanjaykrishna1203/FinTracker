using System;
using System.Collections.Generic;

#nullable disable

namespace FinTracker.Dal.Entity
{
    public partial class User
    {
        public User()
        {
            Debits = new HashSet<Debit>();
            Expenses = new HashSet<Expense>();
            Incomes = new HashSet<Income>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Debit> Debits { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
