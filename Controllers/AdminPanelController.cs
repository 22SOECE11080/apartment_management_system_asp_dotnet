using Microsoft.AspNetCore.Mvc;

namespace apartment_management_system_asp_dotnet.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sidebar()
        {
            return View();
        }
        public IActionResult AdminAddMembers()
        {
            return View();
        }
        public IActionResult Complaints()
        {
            return View();
        }
        public IActionResult NoticeBoard()
        {
            return View();
        }
        public IActionResult HallBooking()
        {
            return View();
        }
        public IActionResult Maintenance()
        {
            return View();
        }
        public IActionResult VehicleInfo()
        {
            return View();
        }
        public IActionResult VisitorManagement()
        {
            return View();
        }
    }
}
