using Microsoft.AspNetCore.Mvc;

namespace ServiceManual.Controllers;

public class RoadmapController : Controller
{
    public IActionResult Index()
    {
        ViewData["ActiveSection"] = "now";
        return View();
    }

    public IActionResult Now()
    {
        return RedirectToAction("Index");
    }

    public IActionResult Next()
    {
        ViewData["ActiveSection"] = "next";
        return View();
    }

    public IActionResult Later()
    {
        ViewData["ActiveSection"] = "later";
        return View();
    }
}

