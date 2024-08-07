using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class ManagerPinCodeModel
    {
        [Key]
        public int Id { get; set; }
        public required int ManagerId { get; set; }
        public required string PinCode { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public UserModel Manager { get; set; }
    }
}
