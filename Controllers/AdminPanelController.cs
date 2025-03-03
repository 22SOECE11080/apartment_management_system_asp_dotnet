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
    }
}
