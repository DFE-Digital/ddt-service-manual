namespace ServiceManual.Models;

/// <summary>
/// News or Announcement articles are timely updates about the Service Manual and digital initiatives.
/// </summary>
public class News
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Slug { get; set; }
    public DateTime PublicationDate { get; set; }
    public string? Author { get; set; }
    public string? AuthorRole { get; set; }
    public required string BodyContent { get; set; }
    public string? ImageUrl { get; set; }
    public string? ImageAlt { get; set; }
    public List<int> RelatedContentIds { get; set; } = new();
    public List<string> Tags { get; set; } = new();
    public List<string> Categories { get; set; } = new();
    public DateTime? PublishedAt { get; set; }
}

