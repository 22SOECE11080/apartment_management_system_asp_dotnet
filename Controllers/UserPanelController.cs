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

        //public IActionResult Booking()
        //{
        //    return PartialView("_Booking");
        //}

        //public IActionResult NoticeBoard()
        //{
        //    return PartialView("_NoticeBoard");
        //}

        //public IActionResult AddVisitor()
        //{
        //    return PartialView("_AddVisitor");
        //}

        //public IActionResult VehicleInfo()
        //{
        //    return PartialView("_VehicleInfo");
        //}
    }
}
