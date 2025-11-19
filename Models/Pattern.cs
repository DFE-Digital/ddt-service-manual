namespace ServiceManual.Models;

/// <summary>
/// A Pattern is a reusable design solution or best practice approach to solve a common user problem.
/// </summary>
public class Pattern
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public required string Summary { get; set; }
    public string? ProblemStatement { get; set; }
    public required string SolutionDetails { get; set; }
    public string? WhenToUse { get; set; }
    public string? HowItWorks { get; set; }
    public List<string> Components { get; set; } = new();
    public List<string> Categories { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public List<int> RelatedStandardIds { get; set; } = new();
    public string? CodeExample { get; set; }
    public string? Owner { get; set; }
    public string? Status { get; set; } // "Official", "Experimental", "Pilot"
    public DateTime? PublishedAt { get; set; }
}

