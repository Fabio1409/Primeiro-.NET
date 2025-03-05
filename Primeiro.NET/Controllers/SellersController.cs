using Microsoft.AspNetCore.Mvc;

namespace PrimeiroDOTNET.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
