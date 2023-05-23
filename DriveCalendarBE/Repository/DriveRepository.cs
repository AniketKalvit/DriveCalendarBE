using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository.Interfaces;

namespace DriveCalendarBE.Repository
{
    public class DriveRepository : IDriveRepository
    {
        private readonly ApplicationDbContext _context;
        public DriveRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int AddDrive(Drive drive)
        {
            int result = 0;
            drive.DriveStatusId = 1;
            _context.Drives.Add(drive);
            result = _context.SaveChanges();
            return result;
        }

        public int DeleteDrive(int id)
        {
            int result = 0;
            var drive = _context.Drives.Where(x => x.DriveId == id).FirstOrDefault();
            if (drive != null)
            {
                drive.IsActive = 0;
                drive.DriveStatusId = 9;
                result= _context.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Drive> GetAllDrives()
        {
            var users = _context.Users.ToList();
            var list = _context.Drives.Where(x => x.IsActive == 1).ToList();
            foreach (var item in users)
            {
                foreach (var d in list)
                {
                    if (d.DriveBy == item.UserId)
                    {
                        d.DriveByName = item.UserName;
                    }
                }
            }
            var driveStatusList = _context.DriveStatus.ToList();
            foreach (DriveStatus obj1 in driveStatusList)
            {
                foreach (Drive drive in list)
                {
                    if (drive.DriveStatusId == obj1.DriveStatusId)
                    {
                        drive.DriveStatus = obj1.StatusName;
                    }
                }
            }
            return list;
        }

        public Drive GetDriveById(int id)
        {
            Drive drive = new Drive();
             drive = _context.Drives.Where(x => x.DriveId == id).FirstOrDefault();
            return drive;
        }

       
        public int UpdateDrive(Drive drive)
        {
            int result = 0;
            var d = _context.Drives.Where(x => x.DriveId == drive.DriveId).FirstOrDefault();
            if (d != null)
            {
                d.SelectionProcess = drive.SelectionProcess;
                d.Location = drive.Location;
                d.JobDescription = drive.JobDescription;
                d.DriveBy = drive.DriveBy;
                d.Bond = drive.Bond;
                d.CompanyName = drive.CompanyName;
                d.Criteria = drive.Criteria;
                d.Package = drive.Package;
                d.DriveStatusId = drive.DriveStatusId;
                d.WorkType = drive.WorkType;
                d.Result = drive.Result;
                d.Positions = drive.Positions;
                d.IsActive = 1;
                d.DriveStatusId = drive.DriveStatusId;
                result = _context.SaveChanges();
            }
            return result;
        }
    }
}
