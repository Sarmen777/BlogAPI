using AutoMapper;
using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Services;
using BlogAPI.SharedLayer;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _service;
        private readonly IMapper _mapper;

        public TagsController(ITagService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_mapper.Map<List<TagDto>>(_service.GetAll()));

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tag = _service.GetById(id);
            if (tag == null) return NotFound();
            return Ok(_mapper.Map<TagDto>(tag));
        }

        [HttpGet("by-name")]
        public IActionResult GetByName([FromQuery] string name)
        {
            var tag = _service.GetByName(name);
            if (tag == null) return NotFound();
            return Ok(_mapper.Map<TagDto>(tag));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateTagDto dto)
        {
            var tag = _mapper.Map<Tag>(dto);
            _service.Add(tag);
            return Ok(_mapper.Map<TagDto>(tag));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateTagDto dto)
        {
            var tag = _service.GetById(id);
            if (tag == null) return NotFound();

            _mapper.Map(dto, tag);
            _service.Update(tag);
            return Ok(_mapper.Map<TagDto>(tag));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
