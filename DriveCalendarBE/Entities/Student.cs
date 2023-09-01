using System.ComponentModel.DataAnnotations.Schema;

namespace DriveCalendarBE.Entities
{
    [Table("tblStudent")]
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public string? BatchName { get; set; }
        public string? Ratings { get; set; }
        public int IsActive { get; set; }

    }
}
