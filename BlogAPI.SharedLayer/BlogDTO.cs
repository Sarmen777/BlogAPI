using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.SharedLayer
{
    public class BlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class CreateBlogDto
    {
        public string Title { get; set; }
    }

    public class UpdateBlogDto
    {
        public string Title { get; set; }
    }
}
