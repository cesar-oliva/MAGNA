using Microsoft.AspNetCore.Mvc;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
