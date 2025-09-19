using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.CL.DomainModels
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
