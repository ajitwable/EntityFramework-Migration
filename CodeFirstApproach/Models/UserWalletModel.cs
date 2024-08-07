using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class UserWalletModel
    {
        [Key]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public decimal Balance { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? ModifiedBy { get; set; }
        public int MyProperty { get; set; }
        public bool IsActive { get; set; } = true;

        public UserModel User { get; set; }
    }
}
