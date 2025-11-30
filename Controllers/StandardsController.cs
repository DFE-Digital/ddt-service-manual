using Microsoft.AspNetCore.Mvc;
using ServiceManual.Services;

namespace ServiceManual.Controllers;

public class StandardsController : Controller
{
    private readonly DdtStandardsApiService _ddtStandardsApiService;
    private readonly ILogger<StandardsController> _logger;

    public StandardsController(
        DdtStandardsApiService ddtStandardsApiService,
        ILogger<StandardsController> logger)
    {
        _ddtStandardsApiService = ddtStandardsApiService;
        _logger = logger;
    }

    /// <summary>
    /// Display all published standards
    /// </summary>
    public async Task<IActionResult> Index(string? search, string? category, int page = 1)
    {
        try
        {
            var response = await _ddtStandardsApiService.GetPublishedStandardsAsync(
                search: search,
                category: category,
                page: page,
                pageSize: 50);

            if (response == null)
            {
                ViewBag.ErrorMessage = "Unable to load standards at this time.";
                return View(new DdtStandardsResponse { Data = new List<DdtStandardDto>() });
            }

            ViewBag.Search = search;
            ViewBag.Category = category;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = response.Pagination?.TotalPages ?? 1;
            ViewBag.TotalRecords = response.Pagination?.TotalRecords ?? 0;

            // Extract unique categories from all standards
            var allCategories = response.Data
                .SelectMany(s => s.Categories)
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            ViewBag.Categories = allCategories;

            // Sort standards alphabetically by title
            response.Data = response.Data.OrderBy(s => s.Title).ToList();

            // Get COMPASS base URL for linking
            var compassBaseUrl = _ddtStandardsApiService.GetCompassBaseUrl();
            ViewBag.CompassBaseUrl = compassBaseUrl;

            return View(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error loading standards");
            ViewBag.ErrorMessage = "An error occurred while loading standards. Please try again later.";
            return View(new DdtStandardsResponse { Data = new List<DdtStandardDto>() });
        }
    }

    /// <summary>
    /// Display details of a specific standard
    /// </summary>
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var standard = await _ddtStandardsApiService.GetStandardByIdAsync(id);

            if (standard == null)
            {
                ViewBag.ErrorMessage = "Standard not found. The standard may not exist or may not be published.";
                // Return view with null model so error message is displayed
                return View((DdtStandardDetailDto?)null);
            }

            // Get COMPASS base URL for linking
            var compassBaseUrl = _ddtStandardsApiService.GetCompassBaseUrl();
            ViewBag.CompassBaseUrl = compassBaseUrl;
            ViewBag.CompassStandardUrl = $"{compassBaseUrl}/DdtStandards/Details/{id}";

            return View(standard);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error loading standard {Id}", id);
            ViewBag.ErrorMessage = "An error occurred while loading the standard. Please try again later.";
            return View((DdtStandardDetailDto?)null);
        }
    }
}

