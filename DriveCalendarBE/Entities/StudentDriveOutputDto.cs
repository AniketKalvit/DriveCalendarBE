namespace DriveCalendarBE.Entities
{
    public class StudentDriveOutputDto
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string? StudentName { get; set; }
        public string? BatchName { get; set; }
        public string? Ratings { get; set; }
        public string? CompanyName { get; set; }
        public string? Location { get; set; }
        public string? StatusName { get; set; }
        public int StudentId { get; set; }
        public int DriveId { get; set; }
        public int IsActive { get; set; }

    }
}
