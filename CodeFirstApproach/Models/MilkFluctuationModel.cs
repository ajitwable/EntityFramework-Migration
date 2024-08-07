using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class MilkFluctuationModel
    {
        [Key]
        public int Id { get; set; }
        public required int UserId { get; set; }
        public Attendance Attendance { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public required UserModel User { get; set; }

    }

    public enum Attendance
    { 
        Present=1,
        Absent=2,
    }
}
