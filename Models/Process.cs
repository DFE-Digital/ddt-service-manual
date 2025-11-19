namespace ServiceManual.Models;

/// <summary>
/// A Process page defines a set of steps or a workflow for governance, assurance, or operational purposes.
/// </summary>
public class Process
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public required string Summary { get; set; }
    public string? Audience { get; set; }
    public string? Prerequisites { get; set; }
    public required string Steps { get; set; }
    public string? Timeline { get; set; }
    public string? Outputs { get; set; }
    public List<int> RelatedToolIds { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public List<string> LifecyclePhases { get; set; } = new();
    public string? ContactEmail { get; set; }
    public string? ContactTeam { get; set; }
    public string? Owner { get; set; }
    public DateTime? PublishedAt { get; set; }
}

