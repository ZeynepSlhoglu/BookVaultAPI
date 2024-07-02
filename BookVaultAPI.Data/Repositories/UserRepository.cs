using BookVaultAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByUsername(string username);
    }
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BookVaultContext context) : base(context)
        {
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username);
        }
    }
}
