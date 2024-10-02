using api.modals;
using api.services.Repositories;
using api.services.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controller
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userService;

        public UserController(IUserRepository userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task <string> GetUsers(){
            return await Task.Run(() => _userService.GetUsers());
        }

        [HttpGet("byid")]
        public async Task<string> GetUsersBiId(int id)
        {
            return await Task.Run(() => _userService.GetUsersById(id));
        }

        [HttpPost("bylogin")]
        public async Task<string> GetLogin(Login login)
        {
            return await Task.Run(() => _userService.GetLogin(login));
        }

        [HttpPost]
        public async Task <bool> PostUser(User user)
        {
            return await Task.Run(() => _userService.PostUser(user));
        }

        [HttpPut]
        public async Task<bool> PutUser(User user)
        {
            return await Task.Run(() => _userService.PutUser(user));
        }

        [HttpDelete]
        public async Task<bool> DeleteUser(int id)
        {
            return await Task.Run(() => _userService.DeleteUser(id));
        }


    }
}
