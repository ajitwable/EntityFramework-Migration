using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DairyDirect.Model
{
    public class RateModel
    {
        [Key]
        public int Id { get; set; }
        public required int MilkTypeId { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Rate { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public MilkTypeModel MilkType { get; set; }
    }
}
