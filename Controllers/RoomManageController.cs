using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OR_Meeting_design.Controllers
{
    public class RoomManageController : Controller
    {
        // GET: RoomManageController
        public ActionResult Booking()
        {
            ViewData["ShowHeaderAndFooter"] = true;
            return View();
        }

        public ActionResult Seraching()
        {
            ViewData["ShowHeaderAndFooter"] = true;
            return View();
        }

    }
}
