using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MAGNA_CLIENT.Application.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    { 
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Privacy()
        {
            return View();
        }
        

    }
}
