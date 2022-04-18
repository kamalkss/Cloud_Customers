using CloudCustomers.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.WebApi.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userServices;
        public UserController(IUserService userServices)
        {
            _userServices = userServices;
        }

        [HttpGet("{id}",Name = "GetAUser")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userServices.GetUserById(id)!;
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpGet( Name = "GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userServices.GetAllUsers();
            return Ok(users);
        }
    }
}
