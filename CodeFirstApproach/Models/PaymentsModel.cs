using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class PaymentsModel
    {
        [Key]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public decimal Amount { get; set; }
        public PaymentTypes PaymentType { get; set; }
        public string? TransactionProof { get; set; }
        public Status Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy  { get; set; }
        public bool IsActive  { get; set; } = true;

        public UserModel User { get; set; }
    }

    public enum PaymentTypes
    {
        Cash = 1,
        Online = 2,
        Check = 3,
    }

    public enum Status
    { 
        Requested = 1,
        Approved = 2,
        Rejected = 3,
    }
}
