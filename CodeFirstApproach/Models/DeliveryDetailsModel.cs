using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class DeliveryDetailsModel
    {
        [Key]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required int MilkTypeId  { get; set; }
        public required int DeliveryTypeId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public UserModel User { get; set; }
        public MilkTypeModel MilkType { get; set; }
        public DeliveryTypeModel DeliveryType { get; set; }
    }
}
