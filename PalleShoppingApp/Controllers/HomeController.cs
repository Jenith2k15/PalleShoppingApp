using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PalleShoppingApp.Models;

namespace PalleShoppingApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration configuration;

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
        this.configuration = configuration;
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["cs"] = configuration["DBConectionString"];
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
