using DriveCalendarBE.Repository.Interfaces;

namespace DriveCalendarBE.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private ApplicationDbContext context;
        public DashboardRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public long GetCurrentMonthPlacement() //pending to implement
        {
            throw new NotImplementedException();
        }

        public long GetTotalDriveCount()
        {
            var result= context.Drives.Count();
            return result;
        }

        public long GetTotalPlacementCount() // 5 selected count
        {
            var result = context.StudentDrives.Where(x => x.StatusId == 5).Count();
            return result;
        }

        public long GetTotalStudentApplied() // 1 applied count
        {
            var result = context.StudentDrives.Where(x => x.StatusId == 1).Count();
            return result;
        }

        public long GetTotalStudentCount()
        {
            var result = context.Students.Count();
            return result;
        }

        public long GetTotalStudentShortlisted() //2 shortlisted count
        {
            var result = context.StudentDrives.Where(x => x.StatusId == 2).Count();
            return result;
        }

        public long GetTotalRejectedStudents() //2 shortlisted count
        {
            var result = context.StudentDrives.Where(x => x.StatusId == 6).Count();
            return result;
        }
    }
}
