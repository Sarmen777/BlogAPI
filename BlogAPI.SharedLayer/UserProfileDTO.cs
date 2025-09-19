using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.SharedLayer
{
    public class UserProfileDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public int UserId { get; set; }
    }

    public class CreateUserProfileDto
    {
        public string FullName { get; set; }
        public string Bio { get; set; }
        public int UserId { get; set; }
    }

    public class UpdateUserProfileDto
    {
        public string FullName { get; set; }
        public string Bio { get; set; }
    }

}
