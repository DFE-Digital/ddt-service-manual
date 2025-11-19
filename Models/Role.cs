namespace ServiceManual.Models;

/// <summary>
/// A Role or Profession page describes digital roles and their responsibilities in DfE.
/// </summary>
public class Role
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public string? RoleType { get; set; } // "Individual Role", "Profession Overview"
    public required string Summary { get; set; }
    public string? Responsibilities { get; set; }
    public string? KeySkills { get; set; }
    public List<int> RelatedStandardIds { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public string? CommunityInfo { get; set; }
    public string? CareerProgression { get; set; }
    public string? SkillsFrameworkUrl { get; set; }
    public List<string> RelatedRoles { get; set; } = new();
    public DateTime? PublishedAt { get; set; }
}

