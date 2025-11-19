namespace ServiceManual.Models;

/// <summary>
/// Tools or Templates are reusable resources such as software tools, services, or document templates.
/// </summary>
public class Tool
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public required string Type { get; set; } // "Tool", "Template", "Software", "Document"
    public required string Description { get; set; }
    public string? UsageGuidance { get; set; }
    public string? FileUrl { get; set; }
    public string? ExternalLink { get; set; }
    public string? Version { get; set; }
    public string? Owner { get; set; }
    public string? OwnerTeam { get; set; }
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public List<int> RelatedStandardIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public DateTime? LastUpdatedDate { get; set; }
    public DateTime? PublishedAt { get; set; }
}

