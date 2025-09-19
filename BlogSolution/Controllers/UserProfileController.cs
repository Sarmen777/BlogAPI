using AutoMapper;
using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Services;
using BlogAPI.SharedLayer;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserProfilesController : ControllerBase
    {
        private readonly IUserProfileService _service;
        private readonly IMapper _mapper;

        public UserProfilesController(IUserProfileService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_mapper.Map<List<UserProfileDto>>(_service.GetAll()));

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var profile = _service.GetById(id);
            if (profile == null) return NotFound();
            return Ok(_mapper.Map<UserProfileDto>(profile));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserProfileDto dto)
        {
            var profile = _mapper.Map<UserProfile>(dto);
            _service.Add(profile);
            return Ok(_mapper.Map<UserProfileDto>(profile));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateUserProfileDto dto)
        {
            var profile = _service.GetById(id);
            if (profile == null) return NotFound();

            _mapper.Map(dto, profile);
            _service.Update(profile);
            return Ok(_mapper.Map<UserProfileDto>(profile));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
