
namespace aspEmpty.Controller
{
    using Microsoft.AspNetCore.Mvc;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
