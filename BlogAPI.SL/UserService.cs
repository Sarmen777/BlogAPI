using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Repositories;
using BlogAPI.CL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.SL
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetByEmail(string email) => _userRepository.GetByEmail(email);
        public User GetByUsername(string username) => _userRepository.GetByUsername(username);
    }
}
