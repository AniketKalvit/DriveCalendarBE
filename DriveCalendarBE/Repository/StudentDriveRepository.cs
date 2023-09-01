using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository.Interfaces;

namespace DriveCalendarBE.Repository
{
    public class StudentDriveRepository : IStudentDriveRepository
    {
        private readonly ApplicationDbContext dbContext;
        public StudentDriveRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int ApplyToDrive(StudentDrive studentDrive)
        {
            studentDrive.IsActive = 1;
           dbContext.StudentDrives.Add(studentDrive);
            int result = dbContext.SaveChanges();
            return result;
        }
        public int UpdateStudentDrive(StudentDrive studentDrive)
        {
            studentDrive.IsActive = 1;
            int result = 0;
            var data = dbContext.StudentDrives.Where(x => x.Id == studentDrive.Id).FirstOrDefault();
            if(data != null)
            {
                data.StudentId = studentDrive.StudentId;
                data.DriveId = studentDrive.DriveId;
                data.StatusId=studentDrive.StatusId;
                result=dbContext.SaveChanges();
            }
            return result;
        }
        public int DeleteStudentDrive(int id)
        {
            int result = 0;
            var data = dbContext.StudentDrives.Where(x => x.Id == id).FirstOrDefault();
            if (data != null)
            {
                data.IsActive = 0;
                result = dbContext.SaveChanges();
            }
            return result;
        }
        public IEnumerable<StudentDriveOutputDto> GetAllStudentDrives()
        {
            IEnumerable<StudentDriveOutputDto> studentDrives = new List<StudentDriveOutputDto>();

            studentDrives = (from d in dbContext.StudentDrives
                          join s in dbContext.Students on d.StudentId equals s.StudentId
                          join dr in dbContext.Drives on d.DriveId equals dr.DriveId
                          join sds in dbContext.StudentDriveStatus on d.StatusId equals sds.StatusId
                          select new StudentDriveOutputDto
                          {
                              Id = d.Id,
                              StatusId = d.StatusId,
                              StatusName = sds.StatusName,
                              StudentName = s.StudentName,
                              BatchName = s.BatchName,
                              StudentId = s.StudentId,
                              Ratings = s.Ratings,
                              CompanyName = dr.CompanyName,
                              Location=dr.Location,
                              DriveId=dr.DriveId,
                              IsActive=d.IsActive,
                          }).Where(x=>x.IsActive==1).ToList();

            return studentDrives;
        }
    }
}
