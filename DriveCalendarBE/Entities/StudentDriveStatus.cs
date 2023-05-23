using System.ComponentModel.DataAnnotations.Schema;

namespace DriveCalendarBE.Entities
{
    [Table("StudentDriveStatus")]
    public class StudentDriveStatus
    {
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
    }
}
