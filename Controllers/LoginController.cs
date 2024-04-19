using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OR_Meeting_design.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Login()
        {
            ViewData["ShowHeaderAndFooter"] = false;
            return View();
        }

        [HttpPost]
        public ActionResult Logins()
        {
            return RedirectToAction("Seraching", "RoomManage");
        }

    }
}
