namespace ServiceManual.Models;

/// <summary>
/// Community or Support pages provide information on communities of practice and support channels.
/// </summary>
public class Community
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public required string Description { get; set; }
    public string? Purpose { get; set; }
    public string? Meetings { get; set; }
    public string? CommunicationChannels { get; set; }
    public List<string> Leaders { get; set; } = new();
    public string? ContactEmail { get; set; }
    public string? SlackChannel { get; set; }
    public string? Resources { get; set; }
    public List<int> RelatedRoleIds { get; set; } = new();
    public List<int> RelatedGuidanceIds { get; set; } = new();
    public string? JoinInstructions { get; set; }
    public DateTime? PublishedAt { get; set; }
}

