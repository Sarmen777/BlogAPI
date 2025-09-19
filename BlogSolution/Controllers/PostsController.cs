using AutoMapper;
using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Services;
using BlogAPI.SharedLayer;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _service;
        private readonly IMapper _mapper;

        public PostsController(IPostService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_mapper.Map<List<PostDto>>(_service.GetAll()));

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var post = _service.GetById(id);
            if (post == null) return NotFound();
            return Ok(_mapper.Map<PostDto>(post));
        }

        [HttpGet("{id}/with-tags")]
        public IActionResult GetWithTags(int id)
        {
            var posts = _service.GetPostsWithTags();
            var filtered = posts.Where(p => p.Id == id);
            return Ok(_mapper.Map<List<PostDto>>(filtered));
        }

        [HttpGet("by-tag")]
        public IActionResult GetByTag([FromQuery] string tag)
        {
            var posts = _service.GetPostsByTag(tag);
            return Ok(_mapper.Map<List<PostDto>>(posts));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreatePostDto dto)
        {
            var post = _mapper.Map<Post>(dto);
            _service.Add(post);
            return Ok(_mapper.Map<PostDto>(post));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdatePostDto dto)
        {
            var post = _service.GetById(id);
            if (post == null) return NotFound();

            _mapper.Map(dto, post);
            _service.Update(post);
            return Ok(_mapper.Map<PostDto>(post));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
