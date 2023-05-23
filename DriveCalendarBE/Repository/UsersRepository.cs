using DriveCalendarBE.Entities;
using DriveCalendarBE.Repository.Interfaces;

namespace DriveCalendarBE.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _context;
        public UsersRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Users Login(Users users)
        {
            var user = _context.Users.Where(x => x.UserName == users.UserName).FirstOrDefault();
            return user;
        }

        public int Register(Users users)
        {
            int result = 0;
            _context.Users.Add(users);
            result= _context.SaveChanges(); 
            return result;

        }
        public List<UserOutPutDTO> GetUserOfPE()
        {
            var users = (from u in _context.Users
                        where u.RoleId == 2
                        select new UserOutPutDTO
                        {
                            UserId=u.UserId,
                            UserName=u.UserName
                        }).ToList();
            return users;
        }
    }
   

}
