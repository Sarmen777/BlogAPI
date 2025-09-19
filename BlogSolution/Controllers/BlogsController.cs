using AutoMapper;
using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Services;
using BlogAPI.SharedLayer;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogService _service;
        private readonly IMapper _mapper;

        public BlogsController(IBlogService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_mapper.Map<List<BlogDto>>(_service.GetAll()));

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var blog = _service.GetById(id);
            if (blog == null) return NotFound();
            return Ok(_mapper.Map<BlogDto>(blog));
        }

        [HttpGet("{id}/posts")]
        public IActionResult GetPostsByBlogId(int id)
        {
            var posts = _service.GetPostsByBlogId(id);
            return Ok(_mapper.Map<List<PostDto>>(posts));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateBlogDto dto)
        {
            var blog = _mapper.Map<Blog>(dto);
            _service.Add(blog);
            return Ok(_mapper.Map<BlogDto>(blog));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateBlogDto dto)
        {
            var blog = _service.GetById(id);
            if (blog == null) return NotFound();

            _mapper.Map(dto, blog);
            _service.Update(blog);
            return Ok(_mapper.Map<BlogDto>(blog));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
