using System.Diagnostics;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ILoginService _loginService;
    
    public HomeController(ILogger<HomeController> logger, ILoginService loginService)
    {
        _logger = logger;
        _loginService = loginService;
    }

    public IActionResult Index()
    {
        var user = _loginService.login("Shanna@melissa.tv", "");
        
        Console.WriteLine(user.Company.CatchPhrase);
        
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