using Microsoft.AspNetCore.Mvc;

namespace SignalRQRReservationWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
