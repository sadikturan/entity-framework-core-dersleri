using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class UserRepository : IUserRepository
    {
        private UserContext context;

        public UserRepository(UserContext _context)
        {
            context = _context;
        }
        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }
    }
}
