using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.DAL
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(BlogContext context) : base(context) { }

        public IEnumerable<Post> GetPostsByBlogId(int blogId)
        {
            return _context.Posts.Where(p => p.BlogId == blogId).ToList();
        }
    }
}
