using Microsoft.AspNetCore.Mvc;

namespace BigBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
