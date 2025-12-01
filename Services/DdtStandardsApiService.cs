using System.Text.Json;
using ServiceManual.Models;

namespace ServiceManual.Services;

/// <summary>
/// Service for interacting with the COMPASS DDT Standards API.
/// </summary>
public class DdtStandardsApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<DdtStandardsApiService> _logger;
    private readonly IConfiguration _configuration;
    private readonly JsonSerializerOptions _jsonOptions;

    public DdtStandardsApiService(
        HttpClient httpClient, 
        ILogger<DdtStandardsApiService> logger,
        IConfiguration configuration)
    {
        _httpClient = httpClient;
        _logger = logger;
        _configuration = configuration;
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    /// <summary>
    /// Get published standards by stage
    /// </summary>
    public async Task<DdtStandardsResponse?> GetPublishedStandardsAsync(
        string? search = null,
        string? category = null,
        int page = 1,
        int pageSize = 50)
    {
        try
        {
            var queryParams = new List<string>
            {
                $"stage=published",
                $"page={page}",
                $"pageSize={pageSize}"
            };

            if (!string.IsNullOrWhiteSpace(search))
            {
                queryParams.Add($"search={Uri.EscapeDataString(search)}");
            }

            if (!string.IsNullOrWhiteSpace(category))
            {
                queryParams.Add($"category={Uri.EscapeDataString(category)}");
            }

            var queryString = string.Join("&", queryParams);
            var url = $"/api/v1/DdtStandards/by-stage?{queryString}";

            _logger.LogInformation("Fetching published standards from {Url}", url);

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<DdtStandardsResponse>(json, _jsonOptions);

            _logger.LogInformation("Successfully fetched {Count} standards", result?.Data?.Count ?? 0);

            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching published standards");
            throw;
        }
    }

    /// <summary>
    /// Get a single published standard by Slug (requires bearer token authentication)
    /// </summary>
    public async Task<DdtStandardDetailDto?> GetStandardBySlugAsync(string slug)
    {
        try
        {
            var url = $"/api/v1/DdtStandards/by-slug/{Uri.EscapeDataString(slug)}";

            _logger.LogInformation("Fetching standard with slug {Slug} from {Url}", slug, url);

            var response = await _httpClient.GetAsync(url);
            
            // Check if response is successful
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                
                // Try to parse error response if it's JSON
                try
                {
                    if (errorContent.TrimStart().StartsWith("{"))
                    {
                        using var errorDoc = JsonDocument.Parse(errorContent);
                        if (errorDoc.RootElement.TryGetProperty("error", out var errorElement))
                        {
                            var errorMessage = errorElement.TryGetProperty("message", out var msg) 
                                ? msg.GetString() 
                                : $"Standard with slug {slug} not found";
                            _logger.LogWarning("API returned status {StatusCode} for standard slug {Slug}: {ErrorMessage}", 
                                response.StatusCode, slug, errorMessage);
                        }
                        else
                        {
                            _logger.LogWarning("API returned status {StatusCode} for standard slug {Slug}. Response: {Content}", 
                                response.StatusCode, slug, errorContent.Substring(0, Math.Min(500, errorContent.Length)));
                        }
                    }
                    else
                    {
                        _logger.LogWarning("API returned status {StatusCode} for standard slug {Slug}. Response: {Content}", 
                            response.StatusCode, slug, errorContent.Substring(0, Math.Min(500, errorContent.Length)));
                    }
                }
                catch
                {
                    _logger.LogWarning("API returned status {StatusCode} for standard slug {Slug}. Response: {Content}", 
                        response.StatusCode, slug, errorContent.Substring(0, Math.Min(500, errorContent.Length)));
                }
                
                return null;
            }

            // Check content type to ensure it's JSON
            var contentType = response.Content.Headers.ContentType?.MediaType;
            if (contentType != null && !contentType.Contains("json"))
            {
                var content = await response.Content.ReadAsStringAsync();
                _logger.LogWarning("API returned non-JSON content type {ContentType} for standard slug {Slug}. Response preview: {Content}", 
                    contentType, slug, content.Substring(0, Math.Min(500, content.Length)));
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            
            // Check if response looks like JSON (starts with { or [)
            if (string.IsNullOrWhiteSpace(json) || (!json.TrimStart().StartsWith("{") && !json.TrimStart().StartsWith("[")))
            {
                _logger.LogWarning("API returned non-JSON response for standard slug {Slug}. Response preview: {Content}", 
                    slug, json.Substring(0, Math.Min(500, json.Length)));
                return null;
            }

            var result = JsonSerializer.Deserialize<DdtStandardDetailDto>(json, _jsonOptions);

            _logger.LogInformation("Successfully fetched standard with slug {Slug}", slug);

            return result;
        }
        catch (JsonException jsonEx)
        {
            _logger.LogError(jsonEx, "JSON deserialization error for standard slug {Slug}. Response may not be valid JSON.", slug);
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching standard with slug {Slug}", slug);
            throw;
        }
    }

    /// <summary>
    /// Get a single published standard by ID
    /// </summary>
    public async Task<DdtStandardDetailDto?> GetStandardByIdAsync(int id)
    {
        try
        {
            var url = $"/api/v1/DdtStandards/by-id/{id}";

            _logger.LogInformation("Fetching standard {Id} from {Url}", id, url);

            var response = await _httpClient.GetAsync(url);
            
            // Check if response is successful
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                
                // Try to parse error response if it's JSON
                try
                {
                    if (errorContent.TrimStart().StartsWith("{"))
                    {
                        using var errorDoc = JsonDocument.Parse(errorContent);
                        if (errorDoc.RootElement.TryGetProperty("error", out var errorElement))
                        {
                            var errorMessage = errorElement.TryGetProperty("message", out var msg) 
                                ? msg.GetString() 
                                : $"Standard with ID {id} not found";
                            _logger.LogWarning("API returned status {StatusCode} for standard {Id}: {ErrorMessage}", 
                                response.StatusCode, id, errorMessage);
                        }
                        else
                        {
                            _logger.LogWarning("API returned status {StatusCode} for standard {Id}. Response: {Content}", 
                                response.StatusCode, id, errorContent.Substring(0, Math.Min(500, errorContent.Length)));
                        }
                    }
                    else
                    {
                        _logger.LogWarning("API returned status {StatusCode} for standard {Id}. Response: {Content}", 
                            response.StatusCode, id, errorContent.Substring(0, Math.Min(500, errorContent.Length)));
                    }
                }
                catch
                {
                    _logger.LogWarning("API returned status {StatusCode} for standard {Id}. Response: {Content}", 
                        response.StatusCode, id, errorContent.Substring(0, Math.Min(500, errorContent.Length)));
                }
                
                return null;
            }

            // Check content type to ensure it's JSON
            var contentType = response.Content.Headers.ContentType?.MediaType;
            if (contentType != null && !contentType.Contains("json"))
            {
                var content = await response.Content.ReadAsStringAsync();
                _logger.LogWarning("API returned non-JSON content type {ContentType} for standard {Id}. Response preview: {Content}", 
                    contentType, id, content.Substring(0, Math.Min(500, content.Length)));
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            
            // Check if response looks like JSON (starts with { or [)
            if (string.IsNullOrWhiteSpace(json) || (!json.TrimStart().StartsWith("{") && !json.TrimStart().StartsWith("[")))
            {
                _logger.LogWarning("API returned non-JSON response for standard {Id}. Response preview: {Content}", 
                    id, json.Substring(0, Math.Min(500, json.Length)));
                return null;
            }

            var result = JsonSerializer.Deserialize<DdtStandardDetailDto>(json, _jsonOptions);

            _logger.LogInformation("Successfully fetched standard {Id}", id);

            return result;
        }
        catch (JsonException jsonEx)
        {
            _logger.LogError(jsonEx, "JSON deserialization error for standard {Id}. Response may not be valid JSON.", id);
            return null;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching standard {Id}", id);
            throw;
        }
    }

    /// <summary>
    /// Get the COMPASS base URL from configuration
    /// </summary>
    public string GetCompassBaseUrl()
    {
        return _configuration["CompassApi:BaseUrl"] ?? "http://localhost:5500";
    }
}

/// <summary>
/// Response model for DDT Standards API
/// </summary>
public class DdtStandardsResponse
{
    public List<DdtStandardDto> Data { get; set; } = new();
    public DdtStandardsPagination? Pagination { get; set; }
    public string? Stage { get; set; }
}

/// <summary>
/// Pagination information
/// </summary>
public class DdtStandardsPagination
{
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
    public int TotalRecords { get; set; }
}

/// <summary>
/// DTO for a DDT Standard from the API
/// </summary>
public class DdtStandardDto
{
    public int Id { get; set; }
    public string? StandardUuid { get; set; }
    public string? LegacyId { get; set; }
    public string? Title { get; set; }
    public string? Slug { get; set; }
    public string? Summary { get; set; }
    public string? Version { get; set; }
    public string? PreviousVersion { get; set; }
    public string? Stage { get; set; }
    public bool IsPublished { get; set; }
    public DateTime? PublishedAt { get; set; }
    public DateTime? FirstPublished { get; set; }
    public DateTime? LastUpdated { get; set; }
    public DateTime? DraftCreated { get; set; }
    public bool? LegalStandard { get; set; }
    public string? LegalBasis { get; set; }
    public int? ValidityPeriod { get; set; }
    public bool GovernanceApproval { get; set; }
    public bool? IsModified { get; set; }
    public DdtStandardCreator? Creator { get; set; }
    public List<DdtStandardOwner> Owners { get; set; } = new();
    public List<DdtStandardContact> Contacts { get; set; } = new();
    public List<string> Categories { get; set; } = new();
    public List<string> SubCategories { get; set; } = new();
    public List<DdtStandardPhase> Phases { get; set; } = new();
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}

public class DdtStandardCreator
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}

public class DdtStandardOwner
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Role { get; set; }
}

public class DdtStandardContact
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
}

public class DdtStandardPhase
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

/// <summary>
/// DTO for a category with its sub-categories
/// </summary>
public class DdtStandardCategoryDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<DdtStandardSubCategoryDto> SubCategories { get; set; } = new();
}

/// <summary>
/// DTO for a sub-category
/// </summary>
public class DdtStandardSubCategoryDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

/// <summary>
/// DTO for a full DDT Standard detail from the API (includes Purpose, HowToMeet, etc.)
/// </summary>
public class DdtStandardDetailDto
{
    public int Id { get; set; }
    public string? StandardUuid { get; set; }
    public string? LegacyId { get; set; }
    public string? Title { get; set; }
    public string? Slug { get; set; }
    public string? Summary { get; set; }
    public string? Purpose { get; set; }
    public string? HowToMeet { get; set; }
    public string? Governance { get; set; }
    public string? Version { get; set; }
    public string? PreviousVersion { get; set; }
    public string? Stage { get; set; }
    public bool IsPublished { get; set; }
    public DateTime? PublishedAt { get; set; }
    public DateTime? FirstPublished { get; set; }
    public DateTime? LastUpdated { get; set; }
    public DateTime? DraftCreated { get; set; }
    public bool? LegalStandard { get; set; }
    public string? LegalBasis { get; set; }
    public int? ValidityPeriod { get; set; }
    public string? RelatedGuidance { get; set; }
    public bool GovernanceApproval { get; set; }
    public bool? IsModified { get; set; }
    public DdtStandardCreator? Creator { get; set; }
    public List<DdtStandardOwner> Owners { get; set; } = new();
    public List<DdtStandardContact> Contacts { get; set; } = new();
    public List<DdtStandardCategoryDto> Categories { get; set; } = new();
    public List<DdtStandardPhase> Phases { get; set; } = new();
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}

