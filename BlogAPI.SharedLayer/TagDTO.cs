using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.SharedLayer
{
    public class TagDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreateTagDto
    {
        [Required]
        public string Name { get; set; }
    }

    public class UpdateTagDto
    {
        [Required]
        public string Name { get; set; }
    }
}
