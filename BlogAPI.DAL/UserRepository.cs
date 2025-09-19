using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.DAL
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(BlogContext context) : base(context) { }

        public User GetByEmail(string email)
        {
            return _dbSet.FirstOrDefault(u => u.Email == email);
        }

        public User GetByUsername(string username)
        {
            return _dbSet.FirstOrDefault(u => u.Username == username);
        }
    }
}
