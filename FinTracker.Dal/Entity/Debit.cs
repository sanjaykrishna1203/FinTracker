using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FinTracker.Dal.Entity
{
    public partial class Debit
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        [Range(100, double.MaxValue)]
        public double TotalAmount { get; set; }
        [Required]
        public double Interest { get; set; }
        [Required]
        public DateTime LoanStartDate { get; set; }
        [Required]
        public DateTime LoanEndDate { get; set; }
        [Required]
        [Range(100, double.MaxValue)]
        public double CurrentOutstanding { get; set; }
        [Required]
        [Range(100, double.MaxValue)]
        public double Emi { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        [Required]
        public int UserRefId { get; set; }
        public bool IsDeleted { get; set; }
        public virtual User UserRef { get; set; }
    }
}
