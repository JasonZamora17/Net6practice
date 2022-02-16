using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Net6Tut.Models;

namespace Net6Tut.Controllers;

public class HomeController : Controller
{
    private Net6TutDbContext db;
    private readonly ILogger<HomeController> _logger;
    public HomeController(Net6TutDbContext context, ILogger<HomeController> logger)
    {
        db = context;
    }

    public IActionResult Index()
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
