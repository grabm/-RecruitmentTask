using CodeReviewTask.Database.Repositories.Users;
using Microsoft.AspNetCore.Mvc;

namespace CodeReviewTask.Api.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
                _userRepository = userRepository;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userRepository.Delete(id);
            return Ok();
        }
    }
}