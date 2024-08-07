using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class InvoiceSettingModel
    {
        [Key]
        public int Id { get; set; }
        public required int TenantId { get; set; }
        public  DateTime InvoiceDate { get; set; }
        public DateTime? CreatedAt  { get; set; }
        public DateTime? ModifiedAt  { get; set; }
        public bool IsActive { get; set; } = true;

        public TenantModel Tenant { get; set; }

    }
}
