using Microsoft.AspNetCore.Mvc;

namespace SignalRQRReservationWebUI.Controllers
{
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
