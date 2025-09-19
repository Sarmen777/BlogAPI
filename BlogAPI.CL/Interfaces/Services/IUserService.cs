using BlogAPI.CL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.CL.Interfaces.Services
{
    public interface IUserService : IService<User>
    {
        User GetByEmail(string email);
        User GetByUsername(string username);
    }
}
