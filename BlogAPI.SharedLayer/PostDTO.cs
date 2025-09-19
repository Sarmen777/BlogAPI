using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.SharedLayer
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
    }

    public class CreatePostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
    }

    public class UpdatePostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
