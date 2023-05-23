using DriveCalendarBE.Entities;

namespace DriveCalendarBE.Services.Interfaces
{
    public interface IDriveService
    {
        public IEnumerable<Drive> GetAllDrives();
        public Drive GetDriveById(int id);
        public int AddDrive(Drive drive);
        public int UpdateDrive(Drive drive);
        public int DeleteDrive(int id);
        
    }
}
