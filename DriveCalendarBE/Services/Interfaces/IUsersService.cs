using DriveCalendarBE.Entities;

namespace DriveCalendarBE.Services.Interfaces
{
    public interface IUsersService
    {
        int Register(Users users);
        LoginOutput Login(Users users);
        List<UserOutPutDTO> GetUserOfPE();
    }
}
