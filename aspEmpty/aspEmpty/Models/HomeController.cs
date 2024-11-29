using Microsoft.AspNetCore.Mvc;

namespace aspEmpty.Models
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
