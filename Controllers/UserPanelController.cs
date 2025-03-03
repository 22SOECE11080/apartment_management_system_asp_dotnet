using Microsoft.AspNetCore.Mvc;

namespace apartment_management_system_asp_dotnet.Controllers
{
    public class UserPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomePage()
        {
            return PartialView("HomePage");
        }

        public IActionResult Maintenance()
        {
            return PartialView("Maintenance");  // ✅ This is correct
        }


        public IActionResult Complain()
        {
            return PartialView("Complain");
        }

        public IActionResult Booking()
        {
            return PartialView("Booking");
        }

        public IActionResult NoticeBoard()
        {
            return PartialView("NoticeBoard");
        }

        public IActionResult AddVisitor()
        {
            return PartialView("AddVisitor");
        }

        public IActionResult VehicleInfo()
        {
            return PartialView("VehicleInfo");
        }
    }
}
