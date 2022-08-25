using System.Diagnostics;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using MyBlog.Models;

namespace MyBlog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ILoginService loginService)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // var user = _loginService.login("Shanna@melissa.tv", "");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}