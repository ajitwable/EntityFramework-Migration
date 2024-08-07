using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class TenantModel
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
