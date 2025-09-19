using AutoMapper;
using BlogAPI.CL.DomainModels;
using BlogAPI.CL.Interfaces.Services;
using BlogAPI.SharedLayer;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.PL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UsersController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _service.GetAll();
            return Ok(_mapper.Map<List<UserDto>>(users));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _service.GetById(id);
            if (user == null) return NotFound();
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpGet("byEmail")]
        public IActionResult GetByEmail([FromQuery] string email)
        {
            var user = _service.GetByEmail(email);
            if (user == null) return NotFound();
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpGet("byUsername")]
        public IActionResult GetByUsername([FromQuery] string username)
        {
            var user = _service.GetByUsername(username);
            if (user == null) return NotFound();
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            _service.Add(user);
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] UpdateUserDto dto)
        {
            var user = _service.GetById(id);
            if (user == null) return NotFound();

            _mapper.Map(dto, user);
            _service.Update(user);
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}
