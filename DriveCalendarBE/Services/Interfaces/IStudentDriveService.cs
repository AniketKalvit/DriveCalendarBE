using DriveCalendarBE.Entities;

namespace DriveCalendarBE.Services.Interfaces
{
    public interface IStudentDriveService
    {
        int ApplyToDrive(StudentDrive studentDrive);
        IEnumerable<StudentDriveOutputDto> GetAllStudentDrives();
        int UpdateStudentDrive(StudentDrive studentDrive);
        int DeleteStudentDrive(int id);
    }
}
