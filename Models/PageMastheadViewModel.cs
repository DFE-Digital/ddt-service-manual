namespace ServiceManual.Models;

public class PageMastheadViewModel
{
    public required string Title { get; set; }
    public string? Summary { get; set; }
    public string? Category { get; set; }
    public string? Tag { get; set; }
    public DateTime? PublishedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public List<BreadcrumbItem>? Breadcrumbs { get; set; }
}

public class BreadcrumbItem
{
    public required string Text { get; set; }
    public string? Href { get; set; }
}

