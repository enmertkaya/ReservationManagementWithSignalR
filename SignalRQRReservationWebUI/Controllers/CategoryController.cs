using Microsoft.AspNetCore.Mvc;

namespace SignalRQRReservationWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
