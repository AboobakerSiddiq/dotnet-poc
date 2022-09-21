using BookStore.API.Models;
using BookStore.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesRepository _roleRepository;

        public RolesController(IRolesRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser(UserModel users)
        {
           var result=await _roleRepository.PostUser(users);
           return Ok(result);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetUserRoles(string userId)
        {
            var result=await _roleRepository.GetUser(userId);
            return Ok(result);
        }
    }
}
