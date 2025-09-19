using BlogAPI.CL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.CL.Interfaces.Services
{
    public interface IPostService : IService<Post>
    {
        IEnumerable<Post> GetPostsWithTags();
        IEnumerable<Post> GetPostsByTag(string tagName);
    }
}
