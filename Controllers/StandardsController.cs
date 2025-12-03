using Microsoft.AspNetCore.Mvc;

namespace ServiceManual.Controllers;

/// <summary>
/// Controller for the Standards hub page that provides an overview of all standards
/// </summary>
public class StandardsController : Controller
{
    /// <summary>
    /// Display the Standards hub page with links to different types of standards
    /// </summary>
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Display the Standards lifecycle guidance page
    /// </summary>
    [Route("standards/standards-lifecycle")]
    public IActionResult StandardsLifecycle()
    {
        return View();
    }

    /// <summary>
    /// Display the Create and publish a standard guidance page
    /// </summary>
    [Route("standards/create-publish-standards")]
    public IActionResult CreatePublishStandards()
    {
        return View();
    }

    /// <summary>
    /// Display the Standards compliance and assurance guidance page
    /// </summary>
    [Route("standards/compliance-assurance")]
    public IActionResult ComplianceAssurance()
    {
        return View();
    }
}

