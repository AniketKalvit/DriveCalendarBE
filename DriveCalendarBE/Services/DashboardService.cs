using DriveCalendarBE.Repository.Interfaces;
using DriveCalendarBE.Services.Interfaces;

namespace DriveCalendarBE.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository repo;
        public DashboardService(IDashboardRepository repo)
        {
            this.repo = repo;
        }
        public long GetCurrentMonthPlacement() //pending to implement
        {
            throw new NotImplementedException();
        }

        public long GetTotalDriveCount()
        {
            return repo.GetTotalDriveCount();
        }

        public long GetTotalPlacementCount()
        {
            return repo.GetTotalPlacementCount();
        }

        public long GetTotalStudentApplied()
        {
            return repo.GetTotalStudentApplied();
        }

        public long GetTotalStudentCount()
        {
            return repo.GetTotalStudentCount();
        }

        public long GetTotalStudentShortlisted()
        {
            return repo.GetTotalStudentShortlisted();
        }
        public long GetTotalRejectedStudents()
        {
            return repo.GetTotalRejectedStudents();
        }
    }
}
