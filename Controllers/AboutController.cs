using Microsoft.AspNetCore.Mvc;

namespace ServiceManual.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

