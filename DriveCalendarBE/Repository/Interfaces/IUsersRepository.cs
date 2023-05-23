using DriveCalendarBE.Entities;

namespace DriveCalendarBE.Repository.Interfaces
{
    public interface IUsersRepository
    {
        int Register(Users users);
        Users Login(Users users);
        List<UserOutPutDTO> GetUserOfPE();
    }
}
