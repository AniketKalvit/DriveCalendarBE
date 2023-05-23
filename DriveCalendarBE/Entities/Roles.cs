using System.ComponentModel.DataAnnotations.Schema;

namespace DriveCalendarBE.Entities
{
    [Table("Roles")]
    public class Roles
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
    }
}
