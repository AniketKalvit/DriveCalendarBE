using DriveCalendarBE.Entities;

namespace DriveCalendarBE.Repository.Interfaces
{
    public interface IStudentDriveRepository
    {
        int ApplyToDrive(StudentDrive studentDrive);

        IEnumerable<StudentDriveOutputDto> GetAllStudentDrives();
        int UpdateStudentDrive(StudentDrive studentDrive);
        int DeleteStudentDrive(int id);
    }
}
