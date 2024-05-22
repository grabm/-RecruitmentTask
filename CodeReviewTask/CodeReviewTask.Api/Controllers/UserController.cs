using Microsoft.AspNetCore.Mvc;

namespace CodeReviewTask.Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
