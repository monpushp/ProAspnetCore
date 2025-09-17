using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProAspnetCore.Models;

namespace ProAspnetCore.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        int hour = DateTime.Now.Hour;
        string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
        return View("MyView", viewModel);
    }

    public IActionResult Welcome(string param1)
    {
        _logger.Log(LogLevel.Error, "Value of param1 = " + param1);
        return View("Welcome", param1);
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
