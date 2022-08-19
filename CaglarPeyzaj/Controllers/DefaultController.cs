using Microsoft.AspNetCore.Mvc;

namespace CaglarPeyzaj.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
