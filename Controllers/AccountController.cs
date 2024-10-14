using Microsoft.AspNetCore.Mvc;

namespace Demo_MVC.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}