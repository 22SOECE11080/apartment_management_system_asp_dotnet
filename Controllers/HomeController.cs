using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using apartment_management_system_asp_dotnet.Models;

namespace apartment_management_system_asp_dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SignIn()
    {
        return View();
    }
    public IActionResult Forget()
    {
        return View();
    }
    public IActionResult Reset()
    {
        return View();
    }

    public IActionResult Confirm()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
