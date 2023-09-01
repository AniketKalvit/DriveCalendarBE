namespace DriveCalendarBE.Services.Interfaces
{
    public interface IDashboardService
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
