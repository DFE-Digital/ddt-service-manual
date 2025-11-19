namespace ServiceManual.Models;

/// <summary>
/// Principles are high-level truths or value statements that guide decision-making and design.
/// </summary>
public class Principle
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public string? PrincipleSet { get; set; } // "Design Principles", "Accessibility Principles", etc.
    public required string Description { get; set; }
    public string? Explanation { get; set; }
    public List<string> Categories { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public List<int> RelatedStandardIds { get; set; } = new();
    public string? Origin { get; set; }
    public string? ExternalReference { get; set; }
    public string? Owner { get; set; }
    public DateTime? EstablishedDate { get; set; }
    public DateTime? PublishedAt { get; set; }
}

