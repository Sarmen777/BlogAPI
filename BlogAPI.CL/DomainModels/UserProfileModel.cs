using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.CL.DomainModels
{
    public class UserProfile
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }
        public string Bio { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
