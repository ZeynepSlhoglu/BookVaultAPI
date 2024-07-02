using AutoMapper;
using BookVaultAPI.DTOs;
using BookVaultAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookVaultAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IMapper _mapper;

        public UserController(UserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult>
    GetUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(usersDto);
        }
    }
}
