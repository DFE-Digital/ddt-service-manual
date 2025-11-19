namespace ServiceManual.Models;

/// <summary>
/// A Standard is a mandatory rule or requirement that DfE teams must follow.
/// </summary>
public class Standard
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public string? ReferenceCode { get; set; }
    public string? Version { get; set; }
    public DateTime PublishedDate { get; set; }
    public DateTime? LastUpdatedDate { get; set; }
    public required string Summary { get; set; }
    public required string BodyContent { get; set; }
    public List<string> Categories { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public string? Owner { get; set; }
    public string? OwnerRole { get; set; }
    public string? Status { get; set; } // "Published", "Proposed", "Under Review"
    public DateTime? PublishedAt { get; set; }
}

