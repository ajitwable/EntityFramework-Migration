using System.ComponentModel.DataAnnotations;

namespace DairyDirect.Model
{
    public class UserModel
    {
       [Key]
       public int Id { get; set; }
       public required string Name {  get; set; }
       public required string Address { get; set; }
       public required string Phone { get; set; }
       public string? Eamil {  get; set; }
       public required string AdharNo { get; set; }
       public required string PasswordHash { get; set; }
       public required string SecurityStamp { get; set; }
       public required int UserRoleId { get; set; }
       public int? ManagerId { get; set; }
       public DateTime CreatedAt { get; set; }
       public DateTime? ModifiedAt { get; set; }
       public int? ModifiedBy { get; set; }
       public bool IsActive { get; set; } = true;

        public UserRoleModel UserRole { get; set; }
        public UserModel Manager { get; set; }
    }
}
