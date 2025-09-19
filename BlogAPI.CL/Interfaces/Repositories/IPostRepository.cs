using BlogAPI.CL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.CL.Interfaces.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetPostsWithTags();
        IEnumerable<Post> GetPostsByTag(string tagName);
    }
}
