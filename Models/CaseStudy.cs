namespace ServiceManual.Models;

/// <summary>
/// A Case Study or Design History captures examples of how teams have built or improved services.
/// </summary>
public class CaseStudy
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public string? Subtitle { get; set; }
    public string? ProjectName { get; set; }
    public DateTime PublicationDate { get; set; }
    public List<string> Authors { get; set; } = new();
    public string? TeamName { get; set; }
    public required string BodyContent { get; set; }
    public List<string> Tags { get; set; } = new();
    public List<string> Topics { get; set; } = new();
    public string? LifecyclePhase { get; set; }
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public List<int> RelatedPatternIds { get; set; } = new();
    public DateTime? PublishedAt { get; set; }
}

