using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class ManagerTenantModel
    {
        [Key]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public required int TenantId { get; set; }

        public UserModel User { get; set; }
        public  TenantModel Tenant { get; set; }
    }
}
