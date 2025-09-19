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
    public class BlogService : Service<Blog>, IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository) : base(blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IEnumerable<Post> GetPostsByBlogId(int blogId) => _blogRepository.GetPostsByBlogId(blogId);
    }
}
