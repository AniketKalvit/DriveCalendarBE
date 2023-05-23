using DriveCalendarBE.Entities;

namespace DriveCalendarBE.Repository.Interfaces
{
    public interface IDriveRepository
    {
         IEnumerable<Drive> GetAllDrives();
         Drive GetDriveById(int id);
         int AddDrive(Drive drive);
         int UpdateDrive(Drive drive);
         int DeleteDrive(int id);
       
    }
}
