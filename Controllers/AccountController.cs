using Demo_MVC.Service;
using Demo_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Demo_MVC.Controllers;

public class AccountController : Controller
{
    private readonly LoginService _loginService;

    public AccountController(LoginService loginService)
    {
        _loginService = loginService;
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        var isUserPresent = await _loginService
            .Login(model.Username, model.Password);
        
        Console.WriteLine("isUserPresent: " + isUserPresent);
        
        if (!isUserPresent)
        {
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return View(model);
        }
        
        return RedirectToAction("Index", "Home");
    }
}