using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.DAL
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(BlogContext context) : base(context) { }

        public IEnumerable<Post> GetPostsWithTags()
        {
            return _dbSet.Include(p => p.PostTags)
                         .ThenInclude(pt => pt.Tag)
                         .ToList();
        }

        public IEnumerable<Post> GetPostsByTag(string tagName)
        {
            return _dbSet.Include(p => p.PostTags)
                         .ThenInclude(pt => pt.Tag)
                         .Where(p => p.PostTags.Any(pt => pt.Tag.Name == tagName))
                         .ToList();
        }
    }
}
