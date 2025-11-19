namespace ServiceManual.Models;

/// <summary>
/// Guidance pages provide practical advice, how-tos, and recommended best practices.
/// </summary>
public class Guidance
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public required string Summary { get; set; }
    public required string BodyContent { get; set; }
    public List<string> Tags { get; set; } = new();
    public List<string> Topics { get; set; } = new();
    public List<string> LifecyclePhases { get; set; } = new();
    public List<string> Roles { get; set; } = new();
    public List<int> RelatedStandardIds { get; set; } = new();
    public List<int> RelatedPatternIds { get; set; } = new();
    public List<int> RelatedToolIds { get; set; } = new();
    public string? Owner { get; set; }
    public DateTime? LastReviewedDate { get; set; }
    public DateTime? PublishedAt { get; set; }
}

