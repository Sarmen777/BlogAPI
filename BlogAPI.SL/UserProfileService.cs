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
    public class UserProfileService : Service<UserProfile>, IUserProfileService
    {
        public UserProfileService(IUserProfileRepository repository) : base(repository) { }
    }
}
