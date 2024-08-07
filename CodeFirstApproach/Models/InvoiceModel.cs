using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class InvoiceModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal Deposit { get; set; }
        public decimal PendingAmount { get; set; }
        public InvoiceStatus Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public UserModel User { get; set; }
    }

    public enum InvoiceStatus
    { 
        Complete = 1,
        Pending = 2,
    }
}
