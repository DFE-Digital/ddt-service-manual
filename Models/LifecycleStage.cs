namespace ServiceManual.Models;

/// <summary>
/// Lifecycle Stage pages describe the phases of service development (Discovery, Alpha, Beta, Live, Retirement).
/// </summary>
public class LifecycleStage
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public int StageOrder { get; set; }
    public required string Summary { get; set; }
    public string? Objectives { get; set; }
    public string? KeyActivities { get; set; }
    public string? EntryCriteria { get; set; }
    public string? ExitCriteria { get; set; }
    public List<string> RecommendedRoles { get; set; } = new();
    public string? Deliverables { get; set; }
    public List<int> RelatedProcessIds { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public List<int> RelatedToolIds { get; set; } = new();
    public List<int> RelatedStandardIds { get; set; } = new();
    public DateTime? PublishedAt { get; set; }
}

