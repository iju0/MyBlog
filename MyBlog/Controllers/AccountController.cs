using System.Security.Claims;
using BLL.Interfaces;
using Core;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers;

public class AccountController : Controller
{
    private readonly ILoginService _loginService;
    public AccountController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(string name, string password, string returnUrl)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
        {
            return RedirectToAction("Login");
        }

        var user = _loginService.login(name, password);

        if (user == null)
        {
            return RedirectToAction("Login");
        }

        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, name),
            new Claim(ClaimTypes.Role, "User")
        }, CookieAuthenticationDefaults.AuthenticationScheme);

        var principal = new ClaimsPrincipal(identity);
        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        if (Utils.IsLocalUrl(returnUrl))
        {
            return Redirect(returnUrl);
        }
        
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult Logout()
    {
        var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Login");
    }
}