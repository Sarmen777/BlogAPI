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
    public class PostService : Service<Post>, IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository) : base(postRepository)
        {
            _postRepository = postRepository;
        }

        public IEnumerable<Post> GetPostsWithTags() => _postRepository.GetPostsWithTags();
        public IEnumerable<Post> GetPostsByTag(string tagName) => _postRepository.GetPostsByTag(tagName);
    }
}
