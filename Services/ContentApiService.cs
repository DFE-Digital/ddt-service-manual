using System.Text.Json;
using ServiceManual.Models;

namespace ServiceManual.Services;

/// <summary>
/// Service for interacting with the Strapi CMS API.
/// Currently returns mock data until the CMS is built.
/// </summary>
public class ContentApiService : IContentApiService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<ContentApiService> _logger;
    private readonly JsonSerializerOptions _jsonOptions;

    public ContentApiService(HttpClient httpClient, ILogger<ContentApiService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
        _jsonOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    // Standards
    public async Task<Standard?> GetStandardBySlugAsync(string slug)
    {
        try
        {
            // TODO: Replace with actual API call when CMS is ready
            // var response = await _httpClient.GetAsync($"api/standards?filters[slug][$eq]={slug}&populate=*");
            // response.EnsureSuccessStatusCode();
            // var json = await response.Content.ReadAsStringAsync();
            // return JsonSerializer.Deserialize<Standard>(json, _jsonOptions);
            
            return GetMockStandard(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching standard by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Standard>> GetAllStandardsAsync()
    {
        try
        {
            // TODO: Replace with actual API call
            return await Task.FromResult(new List<Standard> { GetMockStandard("plain-language") });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all standards");
            return new List<Standard>();
        }
    }

    public async Task<List<Standard>> GetStandardsByCategoryAsync(string category)
    {
        try
        {
            // TODO: Replace with actual API call
            return await Task.FromResult(new List<Standard>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching standards by category: {Category}", category);
            return new List<Standard>();
        }
    }

    // Guidance
    public async Task<Guidance?> GetGuidanceBySlugAsync(string slug)
    {
        try
        {
            return GetMockGuidance(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching guidance by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Guidance>> GetAllGuidanceAsync()
    {
        try
        {
            return await Task.FromResult(new List<Guidance> { GetMockGuidance("accessibility-testing") });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all guidance");
            return new List<Guidance>();
        }
    }

    public async Task<List<Guidance>> GetGuidanceByTopicAsync(string topic)
    {
        try
        {
            return await Task.FromResult(new List<Guidance>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching guidance by topic: {Topic}", topic);
            return new List<Guidance>();
        }
    }

    public async Task<List<Guidance>> GetGuidanceByPhaseAsync(string phase)
    {
        try
        {
            return await Task.FromResult(new List<Guidance>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching guidance by phase: {Phase}", phase);
            return new List<Guidance>();
        }
    }

    // Patterns
    public async Task<Pattern?> GetPatternBySlugAsync(string slug)
    {
        try
        {
            return GetMockPattern(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching pattern by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Pattern>> GetAllPatternsAsync()
    {
        try
        {
            return await Task.FromResult(new List<Pattern>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all patterns");
            return new List<Pattern>();
        }
    }

    public async Task<List<Pattern>> GetPatternsByCategoryAsync(string category)
    {
        try
        {
            return await Task.FromResult(new List<Pattern>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching patterns by category: {Category}", category);
            return new List<Pattern>();
        }
    }

    // Tools
    public async Task<Tool?> GetToolBySlugAsync(string slug)
    {
        try
        {
            return GetMockTool(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching tool by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Tool>> GetAllToolsAsync()
    {
        try
        {
            return await Task.FromResult(new List<Tool>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all tools");
            return new List<Tool>();
        }
    }

    public async Task<List<Tool>> GetToolsByTypeAsync(string type)
    {
        try
        {
            return await Task.FromResult(new List<Tool>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching tools by type: {Type}", type);
            return new List<Tool>();
        }
    }

    // Processes
    public async Task<Process?> GetProcessBySlugAsync(string slug)
    {
        try
        {
            return GetMockProcess(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching process by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Process>> GetAllProcessesAsync()
    {
        try
        {
            return await Task.FromResult(new List<Process>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all processes");
            return new List<Process>();
        }
    }

    // Case Studies
    public async Task<CaseStudy?> GetCaseStudyBySlugAsync(string slug)
    {
        try
        {
            return GetMockCaseStudy(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching case study by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<CaseStudy>> GetAllCaseStudiesAsync()
    {
        try
        {
            return await Task.FromResult(new List<CaseStudy>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all case studies");
            return new List<CaseStudy>();
        }
    }

    public async Task<List<CaseStudy>> GetCaseStudiesByTagAsync(string tag)
    {
        try
        {
            return await Task.FromResult(new List<CaseStudy>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching case studies by tag: {Tag}", tag);
            return new List<CaseStudy>();
        }
    }

    // Roles
    public async Task<Role?> GetRoleBySlugAsync(string slug)
    {
        try
        {
            return GetMockRole(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching role by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Role>> GetAllRolesAsync()
    {
        try
        {
            return await Task.FromResult(new List<Role>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all roles");
            return new List<Role>();
        }
    }

    // Principles
    public async Task<Principle?> GetPrincipleBySlugAsync(string slug)
    {
        try
        {
            return GetMockPrinciple(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching principle by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Principle>> GetAllPrinciplesAsync()
    {
        try
        {
            return await Task.FromResult(new List<Principle>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all principles");
            return new List<Principle>();
        }
    }

    public async Task<List<Principle>> GetPrinciplesBySetAsync(string principleSet)
    {
        try
        {
            return await Task.FromResult(new List<Principle>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching principles by set: {Set}", principleSet);
            return new List<Principle>();
        }
    }

    // Lifecycle Stages
    public async Task<LifecycleStage?> GetLifecycleStageBySlugAsync(string slug)
    {
        try
        {
            return GetMockLifecycleStage(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching lifecycle stage by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<LifecycleStage>> GetAllLifecycleStagesAsync()
    {
        try
        {
            var stages = new List<LifecycleStage>
            {
                GetMockLifecycleStage("discovery"),
                GetMockLifecycleStage("alpha"),
                GetMockLifecycleStage("beta"),
                GetMockLifecycleStage("live"),
                GetMockLifecycleStage("retirement")
            };
            return await Task.FromResult(stages);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all lifecycle stages");
            return new List<LifecycleStage>();
        }
    }

    // Community
    public async Task<Community?> GetCommunityBySlugAsync(string slug)
    {
        try
        {
            return GetMockCommunity(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching community by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<Community>> GetAllCommunitiesAsync()
    {
        try
        {
            return await Task.FromResult(new List<Community>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all communities");
            return new List<Community>();
        }
    }

    // News
    public async Task<News?> GetNewsBySlugAsync(string slug)
    {
        try
        {
            return GetMockNews(slug);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching news by slug: {Slug}", slug);
            return null;
        }
    }

    public async Task<List<News>> GetAllNewsAsync(int page = 1, int pageSize = 10)
    {
        try
        {
            return await Task.FromResult(new List<News>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching all news");
            return new List<News>();
        }
    }

    public async Task<List<News>> GetRecentNewsAsync(int count = 5)
    {
        try
        {
            return await Task.FromResult(new List<News>());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching recent news");
            return new List<News>();
        }
    }

    // Mock data methods (to be removed when CMS is ready)
    private Standard GetMockStandard(string slug)
    {
        return new Standard
        {
            Id = 1,
            Title = "Plain language",
            Slug = "plain-language",
            ReferenceCode = "DDTS-529",
            Version = "1.0",
            PublishedDate = new DateTime(2024, 1, 15),
            Summary = "All content must be written in plain English to ensure it is accessible and understandable to all users.",
            BodyContent = @"<h2>Purpose</h2>
<p>Plain language helps users understand information quickly and easily. It reduces the cognitive load on users and ensures that services are accessible to people of all abilities.</p>

<h2>How to meet this standard</h2>
<ul>
<li>Write in short, clear sentences</li>
<li>Use active voice</li>
<li>Avoid jargon and technical terms where possible</li>
<li>Explain any necessary technical terms</li>
<li>Use headings and bullet points to break up text</li>
</ul>

<h2>When to meet this standard</h2>
<p>This standard applies to all content created for DfE digital services, from discovery through to live.</p>",
            Categories = new List<string> { "Content Design", "Accessibility" },
            Tags = new List<string> { "content", "writing", "accessibility" },
            Owner = "Head of Content Design",
            OwnerRole = "Content Design Lead",
            Status = "Published",
            PublishedAt = new DateTime(2024, 1, 15)
        };
    }

    private Guidance GetMockGuidance(string slug)
    {
        return new Guidance
        {
            Id = 1,
            Title = "How to test for accessibility",
            Slug = "accessibility-testing",
            Summary = "Learn how to test your service for accessibility to ensure it works for all users.",
            BodyContent = @"<h2>Overview</h2>
<p>Accessibility testing helps ensure your service can be used by everyone, including people with disabilities.</p>

<h2>Types of testing</h2>
<h3>Automated testing</h3>
<p>Use tools like WAVE or axe to catch common issues.</p>

<h3>Manual testing</h3>
<p>Test with keyboard navigation and screen readers.</p>

<h2>When to test</h2>
<p>Test throughout the development process, not just at the end.</p>",
            Tags = new List<string> { "accessibility", "testing" },
            Topics = new List<string> { "Accessibility", "Quality assurance" },
            LifecyclePhases = new List<string> { "Alpha", "Beta", "Live" },
            Roles = new List<string> { "Developer", "Designer", "QA Tester" },
            LastReviewedDate = DateTime.Now.AddMonths(-2),
            PublishedAt = new DateTime(2024, 2, 1)
        };
    }

    private Pattern GetMockPattern(string slug)
    {
        return new Pattern
        {
            Id = 1,
            Title = "Ask users for addresses",
            Slug = "ask-for-address",
            Summary = "A consistent way to collect postal addresses from users.",
            WhenToUse = "Use this pattern when you need to collect a user's postal address.",
            SolutionDetails = @"<p>The pattern includes fields for:</p>
<ul>
<li>Address line 1</li>
<li>Address line 2 (optional)</li>
<li>Town or city</li>
<li>County (optional)</li>
<li>Postcode</li>
</ul>",
            Categories = new List<string> { "Forms", "User input" },
            Status = "Official",
            PublishedAt = new DateTime(2024, 1, 20)
        };
    }

    private Tool GetMockTool(string slug)
    {
        return new Tool
        {
            Id = 1,
            Title = "DfE Frontend",
            Slug = "dfe-frontend",
            Type = "Software",
            Description = "A set of reusable components and styles for DfE services, based on the GOV.UK Design System.",
            Version = "2.1.0",
            ExternalLink = "https://github.com/dfe-digital/dfe-frontend",
            Owner = "Design System Team",
            OwnerTeam = "DesignOps",
            Tags = new List<string> { "design-system", "components", "frontend" },
            PublishedAt = new DateTime(2024, 3, 1)
        };
    }

    private Process GetMockProcess(string slug)
    {
        return new Process
        {
            Id = 1,
            Title = "Service assessments",
            Slug = "service-assessments",
            Summary = "Compulsory evaluations at the end of each phase to ensure your service meets the Service Standard.",
            Steps = @"<h2>Step 1: Prepare for assessment</h2>
<p>Review the Service Standard points and gather evidence.</p>

<h2>Step 2: Book an assessment</h2>
<p>Use the Service Assessment booking service.</p>

<h2>Step 3: Present to the panel</h2>
<p>Demonstrate how your service meets each point.</p>

<h2>Step 4: Receive and act on recommendations</h2>
<p>Review the assessment report and address any actions.</p>",
            LifecyclePhases = new List<string> { "Alpha", "Beta", "Live" },
            ContactTeam = "Service Assessment Plus team",
            PublishedAt = new DateTime(2024, 1, 10)
        };
    }

    private CaseStudy GetMockCaseStudy(string slug)
    {
        return new CaseStudy
        {
            Id = 1,
            Title = "Improving consistency across the service",
            Slug = "improving-consistency",
            ProjectName = "Teaching Record System",
            PublicationDate = DateTime.Now.AddMonths(-1),
            Authors = new List<string> { "Jane Smith, Interaction Designer" },
            TeamName = "Teacher Services",
            BodyContent = @"<h2>Background</h2>
<p>We noticed users were confused by inconsistent navigation patterns.</p>

<h2>What we did</h2>
<p>We conducted user research and redesigned the navigation using the DfE Design System.</p>

<h2>Outcome</h2>
<p>User satisfaction increased by 30% and task completion time decreased.</p>",
            Tags = new List<string> { "design", "navigation", "user-research" },
            LifecyclePhase = "Beta",
            PublishedAt = DateTime.Now.AddMonths(-1)
        };
    }

    private Role GetMockRole(string slug)
    {
        return new Role
        {
            Id = 1,
            Title = "Content Designer",
            Slug = "content-designer",
            RoleType = "Individual Role",
            Summary = "Content designers make sure users get the information they need in a clear and accessible way.",
            Responsibilities = @"<ul>
<li>Research user needs and evaluate service usability</li>
<li>Create and maintain content for digital services</li>
<li>Ensure content meets accessibility standards</li>
<li>Collaborate with user researchers and designers</li>
</ul>",
            KeySkills = @"<ul>
<li>Plain English writing</li>
<li>User-centred design</li>
<li>Content strategy</li>
<li>Accessibility awareness</li>
</ul>",
            PublishedAt = new DateTime(2024, 1, 5)
        };
    }

    private Principle GetMockPrinciple(string slug)
    {
        return new Principle
        {
            Id = 1,
            Title = "Accessible design is good design",
            Slug = "accessible-design-is-good-design",
            PrincipleSet = "Accessibility Principles",
            Description = "Good design meets needs and solves problems. If you design something inaccessible, you create barriers.",
            Explanation = "Accessibility should be considered from the start, not added on at the end. When you design accessibly, you create better experiences for everyone.",
            Categories = new List<string> { "Design", "Accessibility" },
            PublishedAt = new DateTime(2024, 1, 1)
        };
    }

    private LifecycleStage GetMockLifecycleStage(string slug)
    {
        return slug.ToLower() switch
        {
            "discovery" => new LifecycleStage
            {
                Id = 1,
                Title = "Discovery",
                Slug = "discovery",
                StageOrder = 1,
                Summary = "Discovery is the first phase of developing a service. In discovery, you investigate the problem and identify users and their needs.",
                Objectives = @"<p>The purpose of discovery is to:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>understand the problem that needs to be solved</li>
<li>identify who the users are and what they need</li>
<li>explore how other organisations are solving similar problems</li>
<li>understand any constraints, like policy or technology</li>
<li>decide whether to proceed to alpha</li>
</ul>",
                KeyActivities = @"<h3 class='govuk-heading-s'>User research</h3>
<p class='govuk-body'>Talk to users to understand their needs, behaviours and pain points. Use a range of research methods including interviews, observations and surveys.</p>

<h3 class='govuk-heading-s'>Mapping and analysis</h3>
<p class='govuk-body'>Map out existing services, processes and user journeys. Identify gaps, pain points and opportunities for improvement.</p>

<h3 class='govuk-heading-s'>Technical investigation</h3>
<p class='govuk-body'>Explore the technical landscape, including existing systems, data sources and any technical constraints or dependencies.</p>

<h3 class='govuk-heading-s'>Policy and constraints</h3>
<p class='govuk-body'>Understand relevant policies, legislation and organisational constraints that will shape the solution.</p>

<h3 class='govuk-heading-s'>Comparative analysis</h3>
<p class='govuk-body'>Look at how other organisations have solved similar problems. Learn from their successes and failures.</p>",
                EntryCriteria = @"<p class='govuk-body'>Before starting discovery, you should have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>a clear brief or problem statement</li>
<li>approval to spend time and money on the discovery</li>
<li>a small, multidisciplinary team in place</li>
<li>support from a senior responsible officer</li>
</ul>",
                ExitCriteria = @"<p class='govuk-body'>By the end of discovery, you should have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>a clear understanding of user needs</li>
<li>a defined problem statement</li>
<li>evidence of the scale and nature of the problem</li>
<li>an understanding of relevant policies and constraints</li>
<li>initial ideas about how the problem might be solved</li>
<li>a recommendation on whether to proceed to alpha</li>
<li>completed a discovery peer review</li>
</ul>",
                RecommendedRoles = new List<string> { "User Researcher", "Service Designer", "Product Manager", "Delivery Manager", "Content Designer" },
                Deliverables = @"<ul class='govuk-list govuk-list--bullet'>
<li>Discovery report summarising findings</li>
<li>User research findings and insights</li>
<li>Service maps and user journey maps</li>
<li>Problem statement</li>
<li>Initial ideas or hypotheses to test in alpha</li>
<li>Recommendation for next steps</li>
</ul>",
                PublishedAt = new DateTime(2024, 1, 1)
            },
            "alpha" => new LifecycleStage
            {
                Id = 2,
                Title = "Alpha",
                Slug = "alpha",
                StageOrder = 2,
                Summary = "In alpha, you test different ways of solving the problem you found in discovery. You'll build prototypes and test them with users.",
                Objectives = @"<p>The purpose of alpha is to:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>test different approaches to solving the problem</li>
<li>learn what works and what does not work for users</li>
<li>understand technical feasibility and constraints</li>
<li>reduce risk by testing ideas quickly</li>
<li>decide on the best approach to build in beta</li>
</ul>",
                KeyActivities = @"<h3 class='govuk-heading-s'>Prototyping</h3>
<p class='govuk-body'>Build quick, low-fidelity prototypes to test different approaches. Start with paper prototypes, then move to interactive prototypes.</p>

<h3 class='govuk-heading-s'>User testing</h3>
<p class='govuk-body'>Test prototypes with users regularly. Use what you learn to improve your prototypes and test again.</p>

<h3 class='govuk-heading-s'>Technical spikes</h3>
<p class='govuk-body'>Investigate technical options and risks. Build proof-of-concepts to test feasibility of different approaches.</p>

<h3 class='govuk-heading-s'>Service design</h3>
<p class='govuk-body'>Map the end-to-end service, including offline elements and internal processes. Identify where design or policy needs to change.</p>

<h3 class='govuk-heading-s'>Content design</h3>
<p class='govuk-body'>Test different ways of explaining things to users. Make sure content meets user needs and is written in plain English.</p>",
                EntryCriteria = @"<p class='govuk-body'>Before starting alpha, you should have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>completed discovery and had a peer review</li>
<li>a clear problem statement and user needs</li>
<li>hypotheses to test in alpha</li>
<li>a multidisciplinary team including developers and designers</li>
<li>approval and funding for alpha</li>
</ul>",
                ExitCriteria = @"<p class='govuk-body'>By the end of alpha, you should:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>have tested several approaches with users</li>
<li>have evidence of which approach works best and why</li>
<li>understand the technical architecture you'll use</li>
<li>know what you'll build in private beta</li>
<li>have a roadmap for beta</li>
<li>pass a service assessment to move to beta</li>
</ul>",
                RecommendedRoles = new List<string> { "User Researcher", "Interaction Designer", "Service Designer", "Content Designer", "Developer", "Technical Architect", "Product Manager", "Delivery Manager" },
                Deliverables = @"<ul class='govuk-list govuk-list--bullet'>
<li>Tested prototypes</li>
<li>User research findings from testing</li>
<li>Technical architecture decisions</li>
<li>Service blueprint</li>
<li>Alpha assessment report</li>
<li>Roadmap for beta</li>
</ul>",
                PublishedAt = new DateTime(2024, 1, 1)
            },
            "beta" => new LifecycleStage
            {
                Id = 3,
                Title = "Beta",
                Slug = "beta",
                StageOrder = 3,
                Summary = "In beta, you build a working version of your service and test it with users. You'll start in private beta with a small group of users, then move to public beta.",
                Objectives = @"<p>The purpose of beta is to:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>build a working service based on what you learned in alpha</li>
<li>test the service with real users doing real tasks</li>
<li>prove the service can handle expected user volumes</li>
<li>meet all accessibility and security requirements</li>
<li>prepare to launch the service to all users</li>
</ul>",
                KeyActivities = @"<h3 class='govuk-heading-s'>Private beta</h3>
<p class='govuk-body'>Launch the service to a small group of users. Monitor how they use it and fix any problems. Keep the old service running alongside.</p>

<h3 class='govuk-heading-s'>Public beta</h3>
<p class='govuk-body'>Open the service to all users, but keep it clearly marked as 'beta'. Continue to improve the service based on user feedback and data.</p>

<h3 class='govuk-heading-s'>Accessibility testing</h3>
<p class='govuk-body'>Test the service with assistive technologies and users with access needs. Fix any accessibility issues you find.</p>

<h3 class='govuk-heading-s'>Performance and load testing</h3>
<p class='govuk-body'>Test that the service can handle the expected number of users and transactions. Optimise performance where needed.</p>

<h3 class='govuk-heading-s'>Security testing</h3>
<p class='govuk-body'>Conduct security assessments and penetration testing. Fix any vulnerabilities before moving to live.</p>

<h3 class='govuk-heading-s'>Operations and support</h3>
<p class='govuk-body'>Set up monitoring, logging and support processes. Plan how you'll operate and maintain the service.</p>",
                EntryCriteria = @"<p class='govuk-body'>Before starting beta, you should have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>passed an alpha service assessment</li>
<li>a tested prototype and clear design direction</li>
<li>technical architecture defined</li>
<li>a multidisciplinary team including operations staff</li>
<li>approval and funding for beta</li>
</ul>",
                ExitCriteria = @"<p class='govuk-body'>By the end of beta, you should:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>have a working service that meets user needs</li>
<li>have evidence the service works for all users including those with access needs</li>
<li>meet all accessibility standards (WCAG 2.2 AA)</li>
<li>have an accessibility statement published</li>
<li>have completed security testing</li>
<li>have performance and support processes in place</li>
<li>pass a service assessment to move to live</li>
</ul>",
                RecommendedRoles = new List<string> { "Product Manager", "Delivery Manager", "User Researcher", "Interaction Designer", "Content Designer", "Frontend Developer", "Backend Developer", "DevOps Engineer", "Technical Architect", "QA Tester", "Performance Analyst" },
                Deliverables = @"<ul class='govuk-list govuk-list--bullet'>
<li>Working service in private and public beta</li>
<li>User research findings from beta testing</li>
<li>Accessibility audit and statement</li>
<li>Security assessment reports</li>
<li>Performance test results</li>
<li>Support and operations documentation</li>
<li>Beta assessment report</li>
</ul>",
                PublishedAt = new DateTime(2024, 1, 1)
            },
            "live" => new LifecycleStage
            {
                Id = 4,
                Title = "Live",
                Slug = "live",
                StageOrder = 4,
                Summary = "Once your service passes its beta assessment, you can remove the 'beta' banner and make it live. You'll continue to improve the service based on user feedback and data.",
                Objectives = @"<p>The purpose of the live phase is to:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>provide a reliable service that consistently meets user needs</li>
<li>continuously improve the service based on user feedback and data</li>
<li>maintain and support the service</li>
<li>ensure the service remains secure and accessible</li>
<li>iterate and add new features as user needs evolve</li>
</ul>",
                KeyActivities = @"<h3 class='govuk-heading-s'>Continuous improvement</h3>
<p class='govuk-body'>Use analytics and user feedback to identify areas for improvement. Prioritise and implement changes regularly.</p>

<h3 class='govuk-heading-s'>User research</h3>
<p class='govuk-body'>Continue to do user research to understand how well the service is meeting needs and where it could be better.</p>

<h3 class='govuk-heading-s'>Monitoring and analytics</h3>
<p class='govuk-body'>Monitor service performance, availability and user behaviour. Use data to inform decisions about improvements.</p>

<h3 class='govuk-heading-s'>Support and operations</h3>
<p class='govuk-body'>Respond to support requests and incidents. Keep the service running smoothly and securely.</p>

<h3 class='govuk-heading-s'>Maintenance</h3>
<p class='govuk-body'>Keep dependencies up to date. Address technical debt. Ensure the service remains secure and compliant.</p>

<h3 class='govuk-heading-s'>Accessibility</h3>
<p class='govuk-body'>Review accessibility annually. Test any new features for accessibility. Keep your accessibility statement up to date.</p>",
                EntryCriteria = @"<p class='govuk-body'>Before going live, you should have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>passed a beta service assessment</li>
<li>a service that meets all standards</li>
<li>operations and support processes in place</li>
<li>monitoring and alerting configured</li>
<li>a plan for continuous improvement</li>
</ul>",
                ExitCriteria = @"<p class='govuk-body'>A service stays live as long as it meets user needs. You may need to retire the service if:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>policy changes mean the service is no longer needed</li>
<li>user needs have changed significantly</li>
<li>the service is being replaced by a better solution</li>
<li>it's no longer cost-effective to maintain</li>
</ul>",
                RecommendedRoles = new List<string> { "Product Manager", "Delivery Manager", "User Researcher", "Interaction Designer", "Content Designer", "Developer", "DevOps Engineer", "Technical Architect", "Support Analyst", "Performance Analyst" },
                Deliverables = @"<ul class='govuk-list govuk-list--bullet'>
<li>Service running in production</li>
<li>Regular analytics and performance reports</li>
<li>User research findings from live service</li>
<li>Incident reports and resolutions</li>
<li>Regular accessibility reviews</li>
<li>Updated documentation</li>
</ul>",
                PublishedAt = new DateTime(2024, 1, 1)
            },
            "retirement" => new LifecycleStage
            {
                Id = 5,
                Title = "Retirement",
                Slug = "retirement",
                StageOrder = 5,
                Summary = "When a service is no longer needed, you need to retire it in a way that's safe for users and the organisation. Plan carefully to avoid disruption.",
                Objectives = @"<p>The purpose of retirement is to:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>safely decommission the service</li>
<li>protect user data and meet legal obligations</li>
<li>redirect users to alternative services if appropriate</li>
<li>preserve important data or records</li>
<li>remove the service from production securely</li>
</ul>",
                KeyActivities = @"<h3 class='govuk-heading-s'>User communication</h3>
<p class='govuk-body'>Tell users well in advance that the service is closing. Explain why and point them to alternatives if available.</p>

<h3 class='govuk-heading-s'>Data management</h3>
<p class='govuk-body'>Decide what to do with user data. Archive what you need to keep for legal reasons. Securely delete everything else.</p>

<h3 class='govuk-heading-s'>Redirects and archives</h3>
<p class='govuk-body'>Set up redirects from the old service to replacements or information pages. Archive content that needs to be preserved.</p>

<h3 class='govuk-heading-s'>Decommissioning</h3>
<p class='govuk-body'>Turn off the service infrastructure. Remove or archive code repositories. Cancel licences and subscriptions.</p>

<h3 class='govuk-heading-s'>Documentation</h3>
<p class='govuk-body'>Document what was retired, why and when. Keep records of how data was handled for audit purposes.</p>",
                EntryCriteria = @"<p class='govuk-body'>Before retiring a service, you should have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>approval to retire the service</li>
<li>a clear plan for handling user data</li>
<li>alternatives identified for users (if appropriate)</li>
<li>a communication plan for users</li>
<li>sufficient time to retire the service safely</li>
</ul>",
                ExitCriteria = @"<p class='govuk-body'>Retirement is complete when you have:</p>
<ul class='govuk-list govuk-list--bullet'>
<li>informed all users about the closure</li>
<li>archived or deleted all data appropriately</li>
<li>set up redirects or information pages</li>
<li>decommissioned all infrastructure</li>
<li>documented the retirement process</li>
<li>closed any open contracts or licences</li>
</ul>",
                RecommendedRoles = new List<string> { "Product Manager", "Delivery Manager", "Technical Architect", "Developer", "DevOps Engineer", "Data Protection Officer", "Content Designer" },
                Deliverables = @"<ul class='govuk-list govuk-list--bullet'>
<li>Retirement plan and timeline</li>
<li>User communications</li>
<li>Data retention and disposal records</li>
<li>Redirect and archive implementation</li>
<li>Decommissioning documentation</li>
<li>Final service report</li>
</ul>",
                PublishedAt = new DateTime(2024, 1, 1)
            },
            _ => new LifecycleStage
            {
                Id = 1,
                Title = "Discovery",
                Slug = "discovery",
                StageOrder = 1,
                Summary = "Discovery is the first phase of developing a service.",
                PublishedAt = new DateTime(2024, 1, 1)
            }
        };
    }

    private Community GetMockCommunity(string slug)
    {
        return new Community
        {
            Id = 1,
            Title = "Design community",
            Slug = "design-community",
            Description = "The design community is a group of designers across DfE who share best practice and support each other.",
            Purpose = "To improve the quality of design across DfE services and build a strong design community.",
            Meetings = "Bi-weekly design meet-up every other Thursday at 2pm",
            CommunicationChannels = "Slack: #design",
            SlackChannel = "#design",
            Leaders = new List<string> { "Head of Design" },
            PublishedAt = new DateTime(2024, 1, 1)
        };
    }

    private News GetMockNews(string slug)
    {
        return new News
        {
            Id = 1,
            Title = "Plain language standard and guidance published",
            Slug = "plain-language-standard-published",
            PublicationDate = DateTime.Now.AddDays(-7),
            Author = "Content Design Team",
            AuthorRole = "Content Design Lead",
            BodyContent = @"<p>The DfE content design community have launched the Plain Language standard, now available on the standards product.</p>

<h2>Improving communication across services</h2>
<p>The new standard ensures all DfE digital services use clear, accessible language that all users can understand.</p>

<h2>A comprehensive guide for all</h2>
<p>The guidance covers writing principles, practical examples, and how to test your content.</p>",
            Tags = new List<string> { "standards", "content-design" },
            Categories = new List<string> { "DesignOps" },
            PublishedAt = DateTime.Now.AddDays(-7)
        };
    }
}

