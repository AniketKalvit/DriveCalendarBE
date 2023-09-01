using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository.Interfaces;
using DriveCalendarBE.Services.Interfaces;

namespace DriveCalendarBE.Services
{
    public class StudentDriveService : IStudentDriveService
    {
        private readonly IStudentDriveRepository repo;
        public StudentDriveService(IStudentDriveRepository repo)
        {
            this.repo = repo;
        }

        public int ApplyToDrive(StudentDrive studentDrive)
        {
            return repo.ApplyToDrive(studentDrive); 
        }

        public IEnumerable<StudentDriveOutputDto> GetAllStudentDrives()
        {
            return repo.GetAllStudentDrives();
        }

        public int UpdateStudentDrive(StudentDrive studentDrive)
        {
            return repo.UpdateStudentDrive(studentDrive);
        }
        public int DeleteStudentDrive(int id)
        {
            return repo.DeleteStudentDrive(id);
        }
    }
}
