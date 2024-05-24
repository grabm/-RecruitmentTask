using CodeReviewTask.Database.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

namespace CodeReviewTask.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserRepository userRepository, ILogger<UserController> logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            _userRepository.Delete(user);

            _logger.LogInformation("User with Id {Id} has been deleted", id);
            return Ok();
        }
    }
}