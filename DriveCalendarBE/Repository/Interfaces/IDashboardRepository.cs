namespace DriveCalendarBE.Repository.Interfaces
{
    public interface IDashboardRepository
    {
        long GetTotalDriveCount();
        long GetTotalStudentCount();
        long GetTotalPlacementCount();
        long GetCurrentMonthPlacement();
        long GetTotalStudentShortlisted();
        long GetTotalStudentApplied();
        long GetTotalRejectedStudents();
    }
}
