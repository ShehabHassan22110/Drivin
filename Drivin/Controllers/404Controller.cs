using Microsoft.AspNetCore.Mvc;

namespace Drivin.Controllers
{
    public class _404Controller : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
