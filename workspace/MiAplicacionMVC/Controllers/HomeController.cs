using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MiAplicacionMVC.Models;

namespace MiAplicacionMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var persona = new Persona(){
            nombre = "Leandro C. Tomassini",
            edad = 31
        };

        return View("index",persona);
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
