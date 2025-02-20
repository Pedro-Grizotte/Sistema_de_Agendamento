using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Agendamento.Models;

namespace Sistema_de_Agendamento.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult Register(User_register user)
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Client()
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
