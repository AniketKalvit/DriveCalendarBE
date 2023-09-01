using DriveCalendarBE.Entities;
using Microsoft.EntityFrameworkCore;

namespace DriveCalendarBE.Repository
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Users> Users { get; set; }
        public DbSet<DriveStatus> DriveStatus { get; set; }
        public DbSet<StudentDriveStatus> StudentDriveStatus { get; set; }
        public DbSet<StudentDrive> StudentDrives { get; set; }
    }
}
