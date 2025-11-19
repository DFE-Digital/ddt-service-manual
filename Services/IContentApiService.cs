using ServiceManual.Models;

namespace ServiceManual.Services;

/// <summary>
/// Interface for interacting with the Strapi CMS API.
/// </summary>
public interface IContentApiService
{
    // Standards
    Task<Standard?> GetStandardBySlugAsync(string slug);
    Task<List<Standard>> GetAllStandardsAsync();
    Task<List<Standard>> GetStandardsByCategoryAsync(string category);
    
    // Guidance
    Task<Guidance?> GetGuidanceBySlugAsync(string slug);
    Task<List<Guidance>> GetAllGuidanceAsync();
    Task<List<Guidance>> GetGuidanceByTopicAsync(string topic);
    Task<List<Guidance>> GetGuidanceByPhaseAsync(string phase);
    
    // Patterns
    Task<Pattern?> GetPatternBySlugAsync(string slug);
    Task<List<Pattern>> GetAllPatternsAsync();
    Task<List<Pattern>> GetPatternsByCategoryAsync(string category);
    
    // Tools
    Task<Tool?> GetToolBySlugAsync(string slug);
    Task<List<Tool>> GetAllToolsAsync();
    Task<List<Tool>> GetToolsByTypeAsync(string type);
    
    // Processes
    Task<Process?> GetProcessBySlugAsync(string slug);
    Task<List<Process>> GetAllProcessesAsync();
    
    // Case Studies
    Task<CaseStudy?> GetCaseStudyBySlugAsync(string slug);
    Task<List<CaseStudy>> GetAllCaseStudiesAsync();
    Task<List<CaseStudy>> GetCaseStudiesByTagAsync(string tag);
    
    // Roles
    Task<Role?> GetRoleBySlugAsync(string slug);
    Task<List<Role>> GetAllRolesAsync();
    
    // Principles
    Task<Principle?> GetPrincipleBySlugAsync(string slug);
    Task<List<Principle>> GetAllPrinciplesAsync();
    Task<List<Principle>> GetPrinciplesBySetAsync(string principleSet);
    
    // Lifecycle Stages
    Task<LifecycleStage?> GetLifecycleStageBySlugAsync(string slug);
    Task<List<LifecycleStage>> GetAllLifecycleStagesAsync();
    
    // Community
    Task<Community?> GetCommunityBySlugAsync(string slug);
    Task<List<Community>> GetAllCommunitiesAsync();
    
    // News
    Task<News?> GetNewsBySlugAsync(string slug);
    Task<List<News>> GetAllNewsAsync(int page = 1, int pageSize = 10);
    Task<List<News>> GetRecentNewsAsync(int count = 5);
}

