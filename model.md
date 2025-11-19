Skip to content
Chat history

You said:
Can you help me understand the information architecture of all these products and services which my team manages. 

I will be working through how we identify common page types, content types, a content model, the need, purpose of the content, how it supports government digital delivery, the users needs, DDAT professions and frameworks. 

Overall, I will be making a Lucid board of the individual structures and sites, mapping, service blueprinting etc. 

The sites are:

Design Manual - https://design.education.gov.uk/
Accessibility and Inclusive design manual - https://accessibility.education.gov.uk/
Architecture manual - https://dfe-digital.github.io/architecture/#dfe-architecture
Design histories - https://design-histories.education.gov.uk/
Job Descriptions - https://job-descriptions.education.gov.uk/
Find and use DDT standards - https://standards.education.gov.uk/
Technical manual - https://technical-guidance.education.gov.uk/
User research manual - https://user-research.education.gov.uk/
Apply the Service Standard - https://apply-the-service-standard.education.gov.uk/




ChatGPT said:
To support your work on mapping the information architecture and content model across these DfE digital products, could you clarify a few points:

What level of depth are you aiming for in the analysis? (e.g. top-level IA only, or full page/content-type breakdown?)

Would you like me to identify overlapping structures or unique elements between the sites?

Should I prioritise identifying how each site supports specific DDAT professions, or just broadly align them to the frameworks?

Are there any known pain points or goals (e.g. consolidation, governance, redesign) driving this review?

Once I have this, I can begin the research and analysis for you.

You said:
I want a full IA along with the types of content, quality of content, overlapping structures and unique content types, or similar ones that can be standardised

identify what a set of standard content types are

Main pain points are navigation is confusing and you jump around manuals for guidance, 

We will be creating a new, single manual to improve and consolidate all this content, and new content, especially for governance and assurance for "What you need to do when"
ChatGPT said:
Thank you. I’ll review the full information architecture of all nine DfE manuals and guidance sites, breaking down page types, content types, structure, and quality. I’ll also highlight overlapping and unique structures, suggest standardisable content types, and identify gaps or pain points contributing to navigation challenges.

This analysis will support your upcoming consolidation into a single manual focused on clearer navigation, improved governance, and clearer timelines for delivery ('what you need to do when'). I’ll get started and let you know once the mapping is ready.

Research completed in 18m · 30 sources · 16 searches
Information Architecture and Content Analysis of DfE Manuals and Guidance Sites

Overview of Current DfE Manuals and Services
The Department for Education (DfE) currently provides a suite of manuals and tools to guide digital teams. These include profession-specific manuals (for design, accessibility, technical, user research, etc.), a catalog of standards, job role descriptions, and services for assessments and accessibility statements. Each site has its own information architecture (IA) and content focus, which has led to overlapping guidance and sometimes confusing navigation. Below is a breakdown of each product’s IA, content types, and how they relate:
DfE Design Manual (design.education.gov.uk)
Purpose & Audience: Provides standards and guidance for designers to create “consistent, accessible, user-centred products and services in the Department for Education”
design.education.gov.uk
. Aimed at the design profession (interaction, service, content designers, etc.). Structure & Content: The Design Manual is organized into sections in its navigation menu
design.education.gov.uk
:
Design System: DfE’s library of reusable styles, components, and patterns, extending the GOV.UK Design System
design.education.gov.uk
design.education.gov.uk
. This section includes sub-pages for foundational styles (e.g. Colour, Typography) and components/patterns (e.g. card, header, “Select a school” pattern)
design.education.gov.uk
. It also has guidance on prototyping (with Figma, GitHub, Heroku setup)
design.education.gov.uk
.
Standards: A page summarizing design standards and principles. (For example, a newly published Plain Language standard was announced here
design.education.gov.uk
.) The Design Manual’s standards are aligned with the central DDT Standards repository; it often links out to the Find and Use Standards site for the definitive list of standards
accessibility.education.gov.uk
.
Content Design: Guidance for content designers – covering content strategy, meeting the Plain Language standard, content quality assurance, publishing workflow, and a style guide
design.education.gov.uk
.
Professions: Information on design roles and skills in DfE. Notably this links to a Design Skills and Capability Framework
design.education.gov.uk
design.education.gov.uk
, detailing what skills are needed for design roles in government. It also includes pages on working groups and meetups
design.education.gov.uk
 to support the design Community of Practice.
Our Work: Likely showcases case studies or team projects (possibly blog-style “news” articles). The homepage’s “What’s new” section highlights news posts (e.g. new standards approved, roadmap updates)
design.education.gov.uk
design.education.gov.uk
. This indicates the manual also shares updates about design governance and evolving standards.
Roadmap: Outlines plans for maturing the design profession in DfE
design.education.gov.uk
design.education.gov.uk
.
DesignOps: Describes how the DesignOps team supports design teams with tools, guidance and operational support
design.education.gov.uk
design.education.gov.uk
. There’s also a contact mechanism for feedback and support from DesignOps.
Notable Content Types: Pattern and component documentation, design principles, style guidelines, and profession/capability frameworks. The Design Manual’s content is high-quality and aligned with GOV.UK standards, but some information (like specific DDT standards) is maintained in other sites, requiring cross-referencing
accessibility.education.gov.uk
. Unique/Overlapping Elements: The DfE Design System is unique to this site (containing DfE-specific UI components and patterns). However, the design standards often overlap with content in the central Standards repository (for example, a “Digital Product Branding” standard is listed centrally
standards.education.gov.uk
 but also referenced as a design principle). The design manual also links out to Design Histories for case studies
design.education.gov.uk
, showing an integration point with that service.
Accessibility & Inclusive Design Manual (accessibility.education.gov.uk)
Purpose & Audience: Offers “standards and guidance for designing and building accessible and inclusive products and services in DfE”
accessibility.education.gov.uk
. It is used by any team member responsible for accessibility outcomes (designers, developers, product managers, etc.). Structure & Content: The Accessibility manual’s IA is broken into logical sections
accessibility.education.gov.uk
:
Standards: Defines the accessibility requirements all DfE products must meet
accessibility.education.gov.uk
. It provides an overview of legal obligations (e.g. Public Sector Accessibility Regulations, Equality Act) and then lists the specific DfE accessibility standards teams must follow
accessibility.education.gov.uk
accessibility.education.gov.uk
. Rather than duplicating full standards text, it points to the Standards repository for details of each standard (e.g. “Accessibility Conformance” DDTS-463)
accessibility.education.gov.uk
. It also describes assurance processes in DfE (like having accessibility assessors and service assessments)
accessibility.education.gov.uk
.
Guidelines: Practical guidance on inclusive design and accessibility best practices. This likely includes how to design for various disabilities, write accessible content, and meet WCAG success criteria. (In a recent update, WCAG guidance was moved under “Standards” where users expected to find it
accessibility.blog.gov.uk
.)
Tools and Testing: Resources for testing accessibility, including assistive technology tools, automated testing, and guidance by impairment type. User research showed teams wanted this organized by the challenges users face and which tools to use in what order
accessibility.blog.gov.uk
accessibility.blog.gov.uk
, leading the content to be refocused on user needs. Now, for example, the manual has guidance like “testing by disability or impairment”
accessibility.education.gov.uk
 linking tools to specific accessibility challenges.
Audits, Issues and Statements: Covers how to get an accessibility audit and handle its outcomes. This includes guidance on the audit process and triage
accessibility.education.gov.uk
, how to track and manage accessibility issues, and how to create legally compliant accessibility statements. (It ties in with the “Manage your accessibility issues and statements” service for generating accessibility statements
accessibility.education.gov.uk
.) Content that was once in a generic “knowledge hub” was reorganized into this section to better fit user expectations
accessibility.blog.gov.uk
accessibility.blog.gov.uk
.
Training: Information on training resources and professional development in accessibility. This might signpost to courses, communities, or cross-government training for building accessibility skills.
Professions: (If present) May outline roles related to accessibility (for instance, the Accessibility Assessor role for service assessments
accessibility.education.gov.uk
accessibility.education.gov.uk
). This helps clarify who in DfE is responsible for accessibility at various stages.
In addition, the Accessibility manual’s homepage features an interactive tool (“How many people?”) to illustrate the prevalence of disabilities in a user base
accessibility.education.gov.uk
 – underlining the importance of inclusive design. A Support page connects users with the DesignOps team for accessibility help, listing contacts and channels for support
accessibility.education.gov.uk
accessibility.education.gov.uk
. Notable Content Types: Accessibility standards (with legal context), practical how-to guides, testing tools, and process docs (audits & statements). The content quality is high, incorporating user research feedback – for example, simplifying language and homepage layout to be more task-focused
accessibility.blog.gov.uk
accessibility.blog.gov.uk
. Unique/Overlapping Elements: Accessibility guidance overlaps with design and technical content (e.g. both the Design and Technical manuals emphasize accessibility principles). However, this manual uniquely consolidates disability-specific guidance and the end-to-end process of compliance (auditing, issues, statements). It relies on the central Standards catalog for the authoritative standards text
accessibility.education.gov.uk
, demonstrating a separation between explanatory guidance here and formal standards elsewhere. The need to jump between this manual and the Standards site or User Research manual is a known pain point – for instance, the Accessibility Conformance standard page explicitly directs readers to guidance in the accessibility manual and to related research guidance in the User Research manual
standards.education.gov.uk
.
DfE Architecture Manual (dfe-digital.github.io/architecture)
Purpose & Audience: Documents architecture principles, standards, patterns and governance for teams designing digital services in DfE
dfe-digital.github.io
. It complements the broader GOV.UK Service Manual and is meant for technical architects, solution architects, enterprise architects and related roles
dfe-digital.github.io
. Structure & Content: The Architecture site is organized into major sections (presented via a table of contents)
dfe-digital.github.io
:
Principles: High-level architectural principles across various domains. For example: Accessibility Principles, Business Architecture Principles, Data Architecture Principles, Enterprise Architecture Principles, Identity Principles, and Technical Architecture Principles
dfe-digital.github.io
dfe-digital.github.io
. These are core rules and “design philosophies” architects should follow. (Notably, the Technical Architecture Principles link goes to the Technical Guidance site
dfe-digital.github.io
, indicating cross-linking rather than duplication.)
Standards: Specific architecture standards or policies. Pages include topics like Architecture Documentation, Business Architecture, Common Definitions, Technical Standards in DfE, Common Components
dfe-digital.github.io
. Some of these likely summarize or reference standards from the central repository (for example, “Technical standards in DfE” presumably points to the DDT Standards list relevant to architects).
Patterns: Reusable solution patterns for common scenarios. The manual lists Infrastructure patterns, Integration patterns, Technical requirements for procurement, Security patterns, and even User-centred design patterns
dfe-digital.github.io
dfe-digital.github.io
. (The latter links out to the Design Manual
dfe-digital.github.io
, again showing inter-manual dependency.)
Governance: Describes how design/architecture governance works in DfE. There is a page on Design governance
dfe-digital.github.io
 which likely covers processes like architectural review boards, technical authority gates, and how teams get architecture approval or exceptions.
Profession: Focused on the people side of the architecture practice. It includes pages on Architecture roles, Architecture profession (likely describing career paths or the community), Architecture community, and an Architecture Capability Framework
dfe-digital.github.io
. This aligns with DDaT profession frameworks and ensures architects in DfE know their development paths and community events.
Repositories: Provides links to shared knowledge bases (like internal SharePoint or Confluence spaces for architecture)
dfe-digital.github.io
. These are pointers to where detailed or sensitive architecture artifacts live (on intranet platforms).
Notable Content Types: Architecture principles & policies, technical patterns, and governance process docs. The content is somewhat technical and policy-oriented. It’s maintained on GitHub, suggesting it’s version-controlled and possibly open to contributions. Quality is generally good, but it often directs users to other resources for deeper guidance (e.g. linking to Technical Guidance or external GOV.UK tech content
dfe-digital.github.io
). Unique/Overlapping Elements: The Architecture principles and patterns are unique to this manual (covering enterprise and system architecture concerns). However, many elements overlap or tie in with other manuals: for instance, it defers to the Technical Guidance for coding-level principles
dfe-digital.github.io
, and to the Design Manual for user-centred design patterns
dfe-digital.github.io
. Similarly, architecture standards often reference the central DDT standards (common components, ADR processes, etc., some of which appear in the “Proposed standards” list
standards.education.gov.uk
standards.education.gov.uk
). This manual also touches on governance and assurance, which is a theme the new single manual will expand (“what you need to do when” in project delivery). Currently, those governance steps (like design reviews, technical approvals) might be scattered here and in the Service Standard manual.
DfE Technical Guidance (technical-guidance.education.gov.uk)
Purpose & Audience: Provides developers and technical team members with detailed guidance on coding, infrastructure, DevOps, and technical best practices in DfE. It “documents the technical standards and guidance” expected when building services
technical-guidance.education.gov.uk
, complementing the Service Standard guidance, Design Manual, Architecture manual, and GOV.UK Service Manual
technical-guidance.education.gov.uk
. Structure & Content: The Technical Guidance site is structured more like a knowledge base (with categories and subpages) than a narrative manual. Key sections include
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
:
Guides: Hands-on guides and tutorials, e.g. Adding a new guidance (how to contribute to this site), DfE Technology Stack (default tech choices)
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
, API guidance, Continuous delivery, Technical Documentation Sites, etc. These guides focus on how to implement processes or use specific technologies in line with DfE’s preferences. For example, the “DfE Technology Stack” guide enumerates recommended programming stacks (C#/.NET as primary, Ruby on Rails secondary, Node.js limited) and hosting infrastructure (Azure cloud, CI/CD tools like Azure DevOps and GitHub Actions)
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
. These recommendations clarify default choices while allowing justified exceptions
technical-guidance.education.gov.uk
.
Principles: Fundamental principles for development. The site lists General principles, Data Principles, Technical Architecture Principles, Coding Principles, Secure by Design principles, Frontend Development Principles
technical-guidance.education.gov.uk
. These likely overlap with or elaborate on principles from the Architecture manual (indeed, “Technical Architecture Principles” appears in both). They cover areas like writing clean code, security-first design, data management, etc., providing high-level guidance that should be reflected in day-to-day engineering.
Standards: Specific technical standards and conventions. Pages include topics such as Naming things (naming conventions)
technical-guidance.education.gov.uk
, Licensing software or code (open source license requirements), Using 3rd-party open source products, Storing source code
technical-guidance.education.gov.uk
. Many of these correspond to formal standards proposals in the central repository – for example, a “Storing source code” standard is listed as being proposed in the DDT Standards site
standards.education.gov.uk
. Until formally approved, the Technical Guidance likely provides interim best-practice guidance on these. This duality highlights overlap: the tech manual gives context and rationale, while the standards site will house the final “must-do” rules.
Infrastructure: Practical guidance on dev infrastructure and operations. This is broken down into subtopics:
Developer tools (common dev tools in DfE),
Hosting (with subpages for Azure Cloud Infrastructure Platform, DNS setup)
technical-guidance.education.gov.uk
,
Security (subpages for SSL certificates, service accounts, managing secrets)
technical-guidance.education.gov.uk
,
Disaster recovery,
Monitoring,
Automation (subpages on GitHub Actions, Azure DevOps pipelines)
technical-guidance.education.gov.uk
,
Support (likely how to get help for technical issues or escalate),
Docker Desktop (usage of Docker for local development)
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
.
These are very specific implementation-level pages. For instance, the Azure CIP page would outline how to request cloud resources in DfE, and the CI/CD pages detail pipeline setup preferences.
Notable Content Types: How-to guides, reference docs for conventions, and “playbooks” for infrastructure tasks. The quality is practical and detailed (including code, scripts, or configuration where appropriate). It’s also versioned on GitHub, indicating a living document. This site is heavily internally focused – explicitly noted that it’s for internal use by the DfE community
technical-guidance.education.gov.uk
 – but still published openly. Unique/Overlapping Elements: The Technical Guidance is unique in covering day-to-day engineering practices and tools. However, it intersects with the Architecture manual on principles and with the central Standards on specific rules (naming, source code management, etc.). It also complements the Service Standard manual for certain points (e.g. Point 11 “Choose the right tools and technology” would naturally link to guidance on tech stack and tools in this manual). Currently, a developer might need to consult this site for how to implement something, and the Standards site for what rules must not be violated, which can be disjointed. Unifying these content types could greatly streamline the developer experience.
Design Histories Service (design-histories.education.gov.uk)
Purpose & Audience: Enables teams across DfE Digital to “work in the open” by documenting how their services’ designs change over time
design-histories.education.gov.uk
. It serves as an internal blogging platform for case studies and design rationale, aimed at both internal colleagues and external stakeholders interested in the evolution of DfE services. Structure & Content: The Design Histories site functions like a collection of blog posts, organized by team and topic:
Home/Recent Posts: The landing page lists recent design history posts in reverse chronological order, each with a title, summary, the project/team name, and date
design-histories.education.gov.uk
design-histories.education.gov.uk
. There are links to view “Older posts” as well
design-histories.education.gov.uk
.
Teams: A directory of teams that have design histories. The Teams page lists each participating team (e.g. Customer Experience and Design, DesignOps, specific service teams like “Get help buying for schools”, “Teacher Recruitment”, etc.) with a short description
design-histories.education.gov.uk
design-histories.education.gov.uk
. Clicking a team shows that team’s posts. This structure encourages browsing by organizational context.
Tags: On the home page, a tag index is provided (e.g. Accessibility, Data, Content design, Design Ops, etc.)
design-histories.education.gov.uk
. Users can find posts by theme or subject matter, cutting across teams.
Guidance for Authors: There is a “Start a design history” section in the nav, which leads to guidance for designers on how to request access and use the content management system (CMS) to create posts
design-histories.education.gov.uk
design-histories.education.gov.uk
. This includes steps like getting approval from a Deputy Director before starting a history, and an online form to request CMS access
design-histories.education.gov.uk
design-histories.education.gov.uk
. Another page, “Manage a design history,” provides detailed instructions on using the CMS (built on Strapi) – how to create teams, services, posts, and best practices for writing entries
design-histories.education.gov.uk
design-histories.education.gov.uk
. It covers content guidelines like writing good post titles, descriptions, linking to prototypes, handling images and alt text for accessibility
design-histories.education.gov.uk
design-histories.education.gov.uk
.
Notable Content Types: The primary content type is Design History posts – essentially case studies or “blog posts” documenting design decisions. These typically include context, what problem was being solved, what was tried, and what the outcome was. They often link to prototypes or design system components used
design-histories.education.gov.uk
, and may incorporate screenshots or snippets with appropriate accessibility considerations
design-histories.education.gov.uk
design-histories.education.gov.uk
. Another content type is Team pages (serving as archives by team), and meta-guidance (how to use the platform). Unique/Overlapping Elements: This platform is unique in focusing on storytelling and retrospectives, rather than prescriptive guidance. It does overlap conceptually with “best practice” sharing – for instance, lessons from design history posts could inform future guidance in the unified manual. The Design Manual’s “Our work” or the DfE Digital blog may sometimes highlight case studies, but Design Histories is dedicated to them. In a unified setup, these posts could be considered “Case Studies” content type, complementing the standards and how-to guidance with real examples. Currently, navigation from the Design Manual encourages designers to read design histories
design.education.gov.uk
, but users have to leave the guidance manual to see them. One notable overlap: the Accessibility manual’s blog post about improving itself concluded by pointing readers to a design history entry for more about the project
accessibility.blog.gov.uk
 – indicating that historical context often lives in design histories while distilled lessons are brought into manuals.
DDaT Job Descriptions Service (job-descriptions.education.gov.uk)
Purpose & Audience: Provides standardized job descriptions for Digital, Data and Technology (DDaT) roles in DfE
job-descriptions.education.gov.uk
. This is useful for hiring managers drafting job adverts, HR professionals, and candidates who want to understand role expectations. It aligns with the Government Digital & Data Profession Capability Framework for consistency
job-descriptions.education.gov.uk
. Structure & Content: The site is structured by profession category, then specific roles:
The homepage lists broad DDaT profession areas and how many roles are available in each:
Architecture – 14 roles
job-descriptions.education.gov.uk
 (covering various architect specialisms),
Data (Data roles – e.g. Data Engineers – with counts),
Software Development (e.g. DevOps roles),
User-Centred Design – which includes sub-disciplines: Accessibility specialists, Content Design, Interaction Design, Service Design, User Research, each with a set of roles at different levels
job-descriptions.education.gov.uk
. (This mirrors the DDaT framework’s structure of roles like junior, mid, senior, lead in each discipline.)
Clicking a category (e.g. Architects) brings up a page that lists all the roles under that category, grouped by specialism and seniority
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
. For example, under Architects: Business Architect; Data Architect (with Senior and Lead); Enterprise Architect (Lead, Head of Profession); Solution Architect (Senior, Lead); Technical Architect (Senior, Lead, Principal)
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
. This page also provides an “Overview” of that profession in DfE – describing generally what architects do and how the roles are differentiated
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
. It explicitly notes alignment to the cross-government DDaT capability framework
job-descriptions.education.gov.uk
, ensuring consistency in role definitions.
Each specific Job Description page contains the details for that role. A job description includes:
Role summary: a description of what the role entails (for instance, what a Senior Data Architect does, and the context of their work)
job-descriptions.education.gov.uk
.
Grade: Civil Service grade of the role (e.g. G7, SCS etc.)
job-descriptions.education.gov.uk
.
Responsibilities (“The role”): A bullet list of main responsibilities and tasks
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
.
Skills/Experience Required: Broken into essential criteria (often split by what is assessed at application vs interview stages) and desirable criteria
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
. These are specific and measurable (similar to person specification in a job advert).
Selection process: Explains how candidates will be evaluated – e.g. application sift, first interview, second interview – and what each stage will focus on
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
. This helps candidates prepare and ensures transparency in hiring.
There is often a link to download the description as a Word document
job-descriptions.education.gov.uk
, which suggests HR use. (Indeed, some search results indicated direct links to Word docs for these JDs.)
The site has feedback links on pages but otherwise minimal navigation beyond “Back to professions” and standard footer links
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
.
Notable Content Types: Job description pages (structured as formal HR documents) and Profession overview pages. The content quality is thorough and standardized, as these are likely the source of truth for recruitment. Each JD is written in alignment with Civil Service job standards and clearly delineates responsibilities and criteria. Unique/Overlapping Elements: This content is unique in format and purpose – no other manual provides hiring information. However, it complements the “Your career” or “Skills framework” content in manuals like Design or User Research. For example, the User Research Manual might advise on career progression or how to apply for jobs
user-research.education.gov.uk
user-research.education.gov.uk
, and then link to the Job Descriptions site for the official role definitions. In a consolidated manual, these JDs could be one content type (possibly under a “Careers” or “Roles” section). Overlap exists in terminology: e.g., design manual’s Design Skills Framework and architecture manual’s Capability Framework both reference what these roles entail, but the job descriptions provide the formal details. Ensuring these are in sync (and possibly merging skill frameworks with JD expectations) is an opportunity in the new IA.
Find and Use DDaT Standards (standards.education.gov.uk)
Purpose & Audience: A single repository of all Digital, Data and Technology standards in DfE, which teams must follow for good service delivery
standards.education.gov.uk
. It’s used by anyone looking for the definitive requirements (e.g., architects, security specialists, product managers preparing for assessments, etc.), as well as by those managing the lifecycle of standards (proposing, reviewing, updating). Structure & Content: The Standards site functions as an index and database of standards:
Standards List: The main “Find a standard” page lets users filter or search through all published standards
standards.education.gov.uk
standards.education.gov.uk
. Standards can be filtered by Category (like Architecture, Security, User-Centred Design and Accessibility, etc.)
standards.education.gov.uk
standards.education.gov.uk
. Each standard is listed by title, with its unique reference code (e.g. “DDTS-463”) and the categories it falls under
standards.education.gov.uk
standards.education.gov.uk
. For example, “Accessibility Conformance” is DDTS-463 under categories Product & Delivery, QA & Development, User-Centred Design & Accessibility
standards.education.gov.uk
. The list is likely alphabetical for easy scanning.
Standard Detail Page: Clicking a standard brings up a structured page. Each standard entry typically includes:
Reference and Version: Unique ID (DDTS-###), version number, and dates published/updated
standards.education.gov.uk
.
Summary: A brief statement of the requirement. For instance, the Accessibility Conformance standard summary: “All services, products, and websites must meet the current published WCAG version to level AA”
standards.education.gov.uk
 (with a warning note that not meeting it breaks the law).
Categories: Which professional or functional categories it applies to, often broken down further by roles or sub-domains (the Accessibility Conformance example lists categories and specific roles like Frontend Development, QA Testing, and UCD roles that it impacts)
standards.education.gov.uk
standards.education.gov.uk
.
Purpose: Why the standard exists – often referencing legal/policy drivers or the underlying principles
standards.education.gov.uk
standards.education.gov.uk
.
How to meet this standard: Guidance or actions teams should take to comply
standards.education.gov.uk
. Importantly, this section often includes cross-links to relevant manuals for practical guidance (e.g., it might point to the Accessibility manual’s guidance on universal design or to User Research manual for inclusive practices)
standards.education.gov.uk
. This is where fragmentation shows: to fully understand implementation, users bounce to other manuals.
Approved products (if applicable): Some standards list approved tools/services that meet the need so teams can adopt them. For example, an Accessibility statements service might be listed as an approved product for managing accessibility statements centrally
standards.education.gov.uk
standards.education.gov.uk
.
Declaring conformance: Instructions on how teams should formally record compliance (e.g., “must be recorded every 12 months” for accessibility conformance)
standards.education.gov.uk
.
Owner and contacts: The name of the standard’s owner or subject matter expert (often a Head of Profession or similar) for queries
standards.education.gov.uk
.
Proposed Standards: A section/page listing standards in draft or review status
standards.education.gov.uk
standards.education.gov.uk
. It shows titles and descriptions of standards that are not yet published for use, indicating what’s in the pipeline (e.g. upcoming standards on “Access to Cloud Resources…”, “Architectural Decision Records”, “Content Management Systems”, etc.)
standards.education.gov.uk
standards.education.gov.uk
. These cannot be viewed in detail (they’re likely internal drafts), but stakeholders can see what’s coming and perhaps engage via the Standards Forum.
Support: A page explaining how to get help regarding standards
standards.education.gov.uk
standards.education.gov.uk
. It provides contacts like a Microsoft Teams channel and an email for the DDT Standards Forum
standards.education.gov.uk
. It also describes the Standards Forum – a group of leads and heads of profession across DDT that meet to review/propose standards
standards.education.gov.uk
. This governance aspect ensures standards are managed collaboratively.
Create & Manage Standards: There’s a link to a separate interface (create-and-manage-standards.education.gov.uk)
standards.education.gov.uk
 likely used by authorized staff to propose or edit standards (not public-facing content, but part of the ecosystem).
Notable Content Types: Standard records (structured policy statements), and meta-content like exportable lists (Excel download of all standards
standards.education.gov.uk
) and proposal listings. Each standard is a controlled document with versioning, owners, and related guidance links. The quality is formal and succinct (mandates rather than tutorials). Unique/Overlapping Elements: This is the authoritative source for “what must be done” in DfE digital services. All manuals overlap with it because they often provide the “how/why” behind these standards. For example, the Accessibility manual essentially interprets and guides teams on standards DDTS-34 (Accessibility Statements) and DDTS-463 (Accessibility Conformance)
accessibility.education.gov.uk
, the User Research manual highlights standards like participant safeguarding and data handling in research
user-research.education.gov.uk
, the Technical guidance covers things like source code management which is turning into a standard
standards.education.gov.uk
, etc. Currently, each manual might list relevant standards with links back to this repository (creating a web of cross-references). The new unified manual will likely incorporate these standards more seamlessly, perhaps by embedding standard content or providing in-context summaries. A set of standard content types to consider here includes: “Standard” (the rule itself) vs. “Guidance” (explanatory content linked to standards). Keeping these connected but not redundant will be important – possibly through a single-source approach where the standard lives in one place and all guidance sections reference it.
Apply the Service Standard (apply-the-service-standard.education.gov.uk)
Purpose & Audience: Offers DfE-specific guidance on how to meet the UK Government Service Standard when developing a service, and explains the service assessment process in DfE. The audience is service teams (product managers, delivery managers, service designers, etc.) preparing for service assessments or peer reviews, ensuring their service meets all points of the Service Standard. Structure & Content: This site is organized around the Service Standard’s 14 points and DfE’s Service Assessments process:
Service Standard Guidance: The homepage prominently lists all the Service Standard points 1 through 14, each as a link
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
. These correspond to the standard GOV.UK Service Standard criteria (from understanding users to operating a reliable service). Clicking each point (e.g. “1. Understand users and their needs”) leads to a DfE-tailored guidance page for that point. Those pages typically outline what that principle means in practice and any DfE policies or resources to help achieve it. For example, for Point 5: Make sure everyone can use the service, the guidance would reference accessibility and assisted digital support, likely pointing to the Accessibility manual or internal requirements. Each page may also note evidence required for assessments.
Service Assessments: There is a section (and top menu link) for Service Assessments
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
. The Site Map reveals multiple pages under this:
Service assessments overview – an introduction to how assessments work in DfE
apply-the-service-standard.education.gov.uk
.
Pages on specific activities: Discovery Peer Reviews (an early-stage lighter review) and how to run them
apply-the-service-standard.education.gov.uk
, Service Assessments (for Alpha/Beta/Live stages) and how to run one
apply-the-service-standard.education.gov.uk
, how to Complete a service assessment report (for assessors to file results)
apply-the-service-standard.education.gov.uk
, how to Manage actions from a service assessment (following up on recommendations)
apply-the-service-standard.education.gov.uk
, how to Support the team during assessments, and how to Give feedback on the assessment process
apply-the-service-standard.education.gov.uk
. Essentially, this is a process blueprint: it’s providing step-by-step manuals for both service teams and assessors on the governance process.
Downloadable Guidance: The homepage offers an Excel download of all guidance for each Service Standard point
apply-the-service-standard.education.gov.uk
. This suggests some users like to see a consolidated checklist or shareable document – a sign that while the web content is comprehensive, teams may still crave one-stop references (one of the very goals of the new consolidated manual).
Integration with Tools: The site’s nav also links to the Service Assessment booking service (under “Services for teams”: Service assessment service for booking assessments
apply-the-service-standard.education.gov.uk
) and to the Accessibility issues and statements service
apply-the-service-standard.education.gov.uk
. So it serves as a hub connecting guidance to actual services that teams must use for compliance.
Notable Content Types: Detailed guidance pages for each Service Standard point (which often compile or link out to resources in design, research, technical, etc., but framed as “how to pass this standard in DfE”). Also, process guidance pages for assessments (essentially internal policy/process docs). The content reads like a manual/checklist for project delivery and assurance. The quality is thorough and specific to DfE’s context – for example, it might mention DfE’s internal boards or required documents alongside the generic GDS criteria. Unique/Overlapping Elements: This manual is unique in that it slices content by user journey stage/governance milestone rather than by profession or content topic. It overlaps with all profession manuals because each Service Standard point touches multiple disciplines (e.g. Point 1 involves user research, Point 5 involves design and accessibility, Point 11 involves technical choices, etc.). In practice, the Apply the Service Standard guide links out to other manuals for depth: indeed, it explicitly references the Design Manual, Technical Guidance, and GOV.UK Service Manual as complementary
technical-guidance.education.gov.uk
. There is some duplication as well – e.g., guidance for Point 12 “Make new source code open” might echo the Open Source policy also found in Technical Guidance standards (like “Use open source products” standard). Crucially, governance and assurance content lives here (the new manual will likely emphasize this “what you need to do when” aspect). Currently, if a team is building a service, they must navigate this site to understand their obligations at each phase, then jump to specific manuals for detailed help. This multi-step navigation is cumbersome. For example, a team preparing for Beta assessment might consult this manual’s Point 5 guidance which tells them to ensure accessibility – then they go to the Accessibility manual to see how to do an audit, then to the Standards site to see the exact standard, and the User Research manual to ensure inclusive research, etc. The pain point is evident: navigation is confusing and users are “jumping around manuals for guidance,” as you described. An example highlighting this fragmentation: the Accessibility standard page in the Standards site literally directs the reader to four different manuals/blogs for how to comply
standards.education.gov.uk
, illustrating the hopping required.
Common Content Types and Overlapping Structures
Across these products, we can identify several recurring content types and structural themes that could be unified:
Standards/Policies: Formal requirements that must be met (e.g. accessibility standards, data standards, coding standards). These are currently centralized in the Standards site as discrete items with IDs (DDTS-#). However, each profession manual has a section for “Standards” where they reiterate or list the standards relevant to that domain (often linking back to the central repository). For instance, the Accessibility manual lists its standards and then refers to the Standards site for details
accessibility.education.gov.uk
, and the User Research manual highlights the existence of UR standards like participant safeguarding
user-research.education.gov.uk
. Opportunity: In a unified IA, “Standards” can be a single content type (with a consistent template of Summary, How to comply, Owner, etc.), tagged by relevant disciplines. Users could filter or view standards in context (e.g. see all standards related to user research or security). This avoids duplicating lists in each section and ensures one source of truth.
Guidance & How-To Content: Practical explanatory material that helps teams meet the standards and do their work. All manuals are rich in guidance:
Accessibility manual has detailed how-to guidance on designing for inclusion, testing, writing statements.
Technical guidance provides how-tos on using tech stacks, deploying, securing apps.
User Research manual gives guidance on conducting research, recruiting participants, etc.
Design manual covers how to apply design patterns, content style, etc.
Apply Service Standard breaks guidance into the 14 points (which are essentially themed how-to guides that span multiple disciplines).
These could be considered “Guidance” content types, which might be organized by topic or by user journey stage. Currently, overlap exists (e.g., guidance on conducting user research with access needs might appear in both the User Research manual and be linked from Accessibility standard guidance). A unified content model could standardize these guides and reduce redundancy by cross-tagging.
Principles and Best Practices: High-level axioms or community principles that guide approach (but aren’t hard standards). Design has design principles (likely aligned with GDS design principles), User Research has community principles
user-research.education.gov.uk
, Technical has coding/security principles, Architecture has architecture principles. These are often overlapping in spirit (user-centric, simplicity, reuse, etc.), but tailored to each domain. In a consolidated manual, Principles could be a shared section with sub-categories (Design, Research, Technical, etc.) or integrated into guidance. They serve as “north star” statements for each profession.
Patterns and Examples: Many manuals provide reusable solutions or examples:
Design Manual’s components and patterns (UI/UX solutions).
Architecture patterns (solution designs like integration or security patterns).
Possibly research “patterns” (methods) could be considered here, though currently the UR manual doesn’t list methods as patterns, its “Guidance library” likely covers different research methods which are analogous to patterns.
Design Histories posts are essentially examples/case studies of problems and how patterns were applied or evolved.
Consolidating these, we might introduce a “Patterns & Examples” content type. It can house design system patterns, technical reference implementations, and case studies (with tags to indicate if something is a reference design or a historical case study).
Toolkits and Templates: Several manuals include concrete tools:
Accessibility manual’s list of testing tools, and even a calculator widget.
User Research manual’s Templates and tools section (likely offering templates for consent forms, discussion guides, spreadsheets for analysis, etc.).
Technical guidance provides links to code repositories, Docker images, etc.
Apply Service Standard provides an Excel checklist download, and links to booking tools.
In a unified site, these could be grouped as “Tools & Templates” – a resource library where users can download artifacts or find interactive widgets. Overlap can be reduced by centralizing: for example, a common template repository for all professions might be easier to maintain than each manual having its own list.
Roles and Career Information: Supporting the DDaT profession framework:
The Job Descriptions site is the authoritative list of roles and their descriptions.
Design Manual’s Skills framework and User Research’s Career pages describe what skills/competencies are expected at various levels.
Architecture manual’s roles and capability framework similarly covers this.
There’s overlap in that these all draw from the same DDaT competency framework. A unified manual could have a “Careers & Roles” section consolidating all role profiles, skill frameworks, and guidance on professional development. Standardizing content types like “Job Role” (with fields for responsibilities, skills, etc.) and “Career Path/Framework” would ensure consistency. For example, the content “All roles align with the Government Digital and Data Profession Capability Framework”
job-descriptions.education.gov.uk
 should be a one-time note, not repeated in each manual.
Community and Support: Every discipline fosters a community:
User Research manual has extensive community info (meetups, Slack channels, onboarding new researchers)
user-research.education.gov.uk
user-research.education.gov.uk
.
Design has DesignOps support and working groups, meetups
design.education.gov.uk
.
Architecture references community events or forums (architecture community meetings, etc.).
Accessibility has DesignOps offering support and Slack channels
accessibility.education.gov.uk
.
Unification could mean a common “Community & Support” hub where each profession has a subsection. This would clarify where to go for help (instead of each manual hiding support contacts in footers or support pages). It also encourages cross-disciplinary community links (e.g., a product manager might easily find there’s a research community and a design community, not just the one they knew about).
Process Guidance / “What to do when”: Some content is timeline-based:
Apply Service Standard is explicitly organized this way (discovery → alpha → beta → live, and within that, how to get assessments done).
Architecture governance might have steps for architecture review at certain project stages.
Accessibility might have guidance on when to run audits (e.g., before public beta) and when to publish statements.
Security likely has steps for penetration testing or accreditation at certain stages.
A new manual can introduce a “Delivery Lifecycle” or “Governance Checklist” content type that aggregates all these “what to do when” pieces into a coherent sequence. This addresses your main pain point directly: right now a team has to piece together a timeline from multiple sources. A unified timeline could reference all needed tasks (e.g., “Before Beta: conduct accessibility audit
accessibility.education.gov.uk
, complete a peer design review, prepare for service assessment, ensure data protection impact assessment, etc.” with each linked to detailed guidance).
Feedback Mechanisms: Not exactly content, but structurally every site has a feedback component (the “Is this page useful?” prompt
design-histories.education.gov.uk
 or “Tell us what you think”
design.education.gov.uk
). In a unified site, this would be standard throughout, feeding into one backlog for continuous improvement. This is more of an IA feature than content type, but worth noting as part of consistency/quality: all manuals value user feedback for continuous iteration, as evidenced by user research leading to the accessibility manual improvements
accessibility.blog.gov.uk
.
Overlaps in Structure: All manuals have navigation that includes cross-links to the others (via the “Profession guidance and information” mega-menu)
design.education.gov.uk
user-research.education.gov.uk
. This indicates they were intended to be a suite. However, the grouping of content within each often differs by the focus of that discipline, which can be confusing (e.g., both the Accessibility and User Research manuals have a “Standards” section, but one refers to WCAG and legal requirements, while the other lists internal research standards – different scopes under the same label). Also, some manuals had unique labels for similar concepts (Accessibility used “Guidelines”, whereas others might just say “Guidance”; design used “Design system” for its tools, whereas research says “Templates and tools”, etc.). This can be standardized. Quality of content is generally high across all these sources – they are written by subject matter experts and often reference best practices or legal requirements. The main quality issue is not accuracy or depth, but findability and cohesion. Users reported difficulty finding what they needed when content was buried under an unexpected section (for example, early feedback on the Accessibility manual showed the “knowledge hub” section was too broad and hid important info
accessibility.blog.gov.uk
). This was mitigated by reorganizing content into more intuitive sections
accessibility.blog.gov.uk
. Similarly, because content lives on different sites, users might not even realize guidance exists. Overlap means some topics are addressed in multiple places (risking inconsistencies): e.g., “how to do accessible research” could appear in both the accessibility site and user research site; “open source policy” appears in technical standards and Service Standard point 13.
Unique Content Types and Consolidation Opportunities
While much can be standardized, a few content types are unique and will need special treatment in a single manual:
Design System Components (from the Design Manual): These are highly specific UI/UX assets with code and usage guidelines. They might live in a separate frontend repository but should be linked. In a unified site, they could be one section (e.g., a “Design System” section) since they are primarily used by designers and developers. This is not relevant to, say, the user research community, but having them under one roof with clear labeling could still be beneficial.
Design Histories (Case Studies): Currently a separate service due to the nature of content (numerous posts, CMS-backed). In a single manual, these could be pulled in via a feed or integrated as a “Case Studies” library. They are valuable for exemplars and sharing lessons learned. The unified IA could tag or relate guidance pages with relevant case studies for context. For instance, a guidance page on “Iterate and improve frequently” (Service Standard point 8) could link to a design history post showing iteration in action. Maintaining the interactivity (tagging by team, etc.) is possible within one site if the content type “Case Study” is defined.
Service and Tools for Teams: The “Service assessment booking” and “Accessibility statement generator” are actual web tools outside the manuals. In a unified experience, these could appear as actions or buttons in relevant guidance (for example, after reading how to prepare for an assessment, a user could click “Book an assessment” which leads into the service-assessments tool). They might remain separate applications, but the navigation and content design should treat them as part of the journey, not entirely separate sites.
Governance & Assurance “Playbooks”: e.g., “Run a discovery peer review” instructions or “Complete an assessment report” are quite specific process docs, mostly for assessors or delivery managers. These might be unique to the Service Standard manual. In a new manual, they might form a “Governance” section or appendix that outlines all assurance activities (service assessments, peer reviews, compliance checks like architecture reviews, spend controls, etc.). This would be new content to consolidate fully, but one can leverage what’s in the Service Standard site and Architecture governance pages.
Content Quality and Voice: Not a content type, but worth noting: because these manuals were written by different teams, tone and depth vary slightly. Unification will require establishing a consistent style (likely aligned with GOV.UK style and plain English). Some content may need rewriting or trimming to remove duplication. For example, the job descriptions have a very formal HR tone, whereas design guidance is conversational. A single site can accommodate different tones in different sections but should aim for coherence. This might mean encapsulating the JDs in a clearly labeled HR section, for instance.
Toward a Unified Information Architecture – Recommendations
To improve navigation and consolidate guidance, a new single manual could be structured by both user needs and common content types, such as:
Home: A clear start page that directs different professionals to what they need (e.g., “I need to… ensure my service meets standards / find guidance by discipline / see what to do at this project phase”). It would immediately signpost major sections like Standards, Delivery Process, Design System, etc., rather than silo by legacy site.
Standards Hub: One place for all DfE digital standards with filtering by category/profession. Each standard page would embed links to relevant guidance. For example, the Plain Language Standard page would link to content design guidance for writing in plain English, instead of that guidance living in a separate silo. This hub ensures a team looking for “what are the rules I must follow” finds them easily
standards.education.gov.uk
.
Guidance Library: A well-organized library of guidance documents/tutorials, possibly structured by themes like Design & Content, User Research, Technology & Security, Data, Accessibility & Inclusion, Delivery & Governance. Under each theme, guidance could be further broken down. For instance, Design & Content might include subtopics for Interaction Design, Content Design, Visual Design; Technology might include DevOps, Coding, Infrastructure, etc. Importantly, a robust search and cross-referencing system should tie them together (so searching “WCAG” or “screen reader” brings up both the standard and the how-to test with a screen reader). This addresses the prior confusion where users weren’t sure which manual to search in. Now one search covers all content.
Delivery (Lifecycle) Playbook: A chronological “what you need to do when” guide, outlining stage-by-stage what activities, reviews, or standards apply. This could map to Discovery, Alpha, Beta, Live phases:
For Discovery: ensure you have user researchers, do discovery research, possibly undergo a peer review – with links to guidance on each (e.g., how to do discovery research, how to run a peer review).
For Alpha/Beta: include design prototypes (link to design system), conduct accessibility audits, prepare for service assessment – with checklists linking to relevant standards (security testing, performance testing) and guidance (how to get an accessibility audit
accessibility.education.gov.uk
, how to do usability testing, etc.).
For Live & Continuous Improvement: cover ongoing obligations (annual accessibility re-certification
standards.education.gov.uk
, live service assessments, monitoring analytics, incident management).
Essentially, this becomes an overarching blueprint ensuring nothing falls through the cracks. It would greatly reduce the need to hop between manuals because this section itself aggregates cross-discipline requirements in one timeline. It also provides context to the standards and guidance – answering when and why you use them, not just what and how.
Design System & Resources: A section for all design/front-end resources: including DfE styles, components, patterns with usage guidance (likely pulled from the existing design system docs). This remains a standalone section due to its specific audience and format (code snippets, etc.), but integrated into the site navigation. Non-designers can largely ignore it, but it’s there for completeness and to signal that these are official resources (which supports Standard 13: reuse open components and patterns
apply-the-service-standard.education.gov.uk
).
Community & People: Combining “Working in DfE” content. This would have:
Roles & Careers: all job descriptions and career frameworks so staff can understand progression. For instance, subpages for each profession summarizing the roles (much like the current job description site’s profession pages
job-descriptions.education.gov.uk
, but also linking to things like the “Design skills framework” document
design.education.gov.uk
 or UR career info
user-research.education.gov.uk
).
Communities of Practice: contacts, meetups, Slack channels, working groups across all professions. Perhaps each profession gets a subpage with its community info (like UR community page, Design community page, etc.), but with a consistent format (who to contact, how to join, when meetups happen, what knowledge repositories exist).
Onboarding Guides: e.g., the “Information for new starters” in UR manual
user-research.education.gov.uk
 can sit here, possibly generalized for any new digital staffer with links to each profession’s specifics.
Design Histories / Portfolio of work: a section that showcases case studies from across DfE. This could be a curated selection or an integrated feed. Alternatively, design histories could remain separate but highlighted via links or RSS feed on the unified site. A “Portfolio” section might highlight notable projects and link to their design history posts, giving readers narrative examples of transformation.
Governance & Support Services: Information on services like booking assessments, the accessibility statement generator, etc., possibly as part of the Delivery or Standards sections. For example, when reading about accessibility compliance, a user could follow a link to the accessibility statement service directly. This section might also explain governance bodies like the Standards Forum, Architecture review board, etc., so teams know where guidance and approvals come from (some of this appears in the Standards support page
standards.education.gov.uk
 and Architecture governance).
By identifying these as standard content types (Standards, Guidance, Principles, Patterns, Tools, Roles, Case Studies, Process/Stage guides, etc.), we can design the new IA so that each type has a clear place. The user shouldn’t need to know “which manual” something is in – they should navigate by what task or information they need. For example, a user need “How do I test my service with users who have disabilities?” would surface as a single guidance page or chapter, instead of them guessing whether that’s under Accessibility manual “Tools and testing” or User Research manual “Guidance”.
Pain Points and How the New IA Will Alleviate Them
As noted, navigation is confusing in the current state. Users have to jump among multiple sites to gather guidance for one task. A concrete example is complying with an accessibility standard:
A product manager might check the Standards site to see the requirement (e.g. must meet WCAG AA)
standards.education.gov.uk
.
They then go to the Accessibility manual to learn how to run an audit and fix issues
accessibility.education.gov.uk
.
They might also need the User Research manual for how to include users with disabilities in testing
standards.education.gov.uk
.
Then, the Technical guidance might be needed if there are technical fixes or to ensure code meets standards.
Finally, they report compliance perhaps via the Accessibility statements service.
This is a lot of hopping, and each hop assumes the user knows the other resource exists. Even within a single manual, earlier IA choices proved suboptimal (e.g., the “knowledge hub” in the Accessibility manual confused users on where to find certain info
accessibility.blog.gov.uk
). DfE already took steps by reorganizing that content more intuitively (moving WCAG info under Standards, creating a Tools section)
accessibility.blog.gov.uk
. This user-centered approach should extend to the whole ecosystem. The unified manual will standardize navigation labels and reduce duplication. Common topics that were scattered can be consolidated. For example:
“Accessibility” will not be split between an Accessibility site and related bits in others; it will be one integrated topic with cross-links instead of separate silos.
“Standards” will be a one-stop catalog (no need to recall the URL of the separate standards site).
“Service Assessments” info will sit alongside the standards and guidance that teams must heed for assessment, making it clear how preparation and execution align.
Finally, by establishing a single source of truth for each content type, we maintain quality and consistency more easily. If a new standard is introduced, it gets added to the Standards section and automatically appears in filtered lists for related guidance. If a case study offers a new lesson, it can be linked in relevant guidance without readers leaving the site. If a job role is updated, the career section and any mention in guidance (like “contact your Lead Data Architect”) can be updated in one place. In summary, the new information architecture will identify standard content types (such as Standards, Guidance, Principles, Patterns, Tools, Roles, Case Studies, and Process checklists) and present them in a unified, user-need-centric way. This will eliminate the current fragmentation where “manuals” are separate; instead, users will experience one coherent DfE Digital Handbook that supports them end-to-end. The result should be a greatly improved ability to find what they need, when they need it, without jumping around – fulfilling the goal of a single manual that consolidates all this rich content and addresses governance “what you need to do when” clearly and holistically. Sources:
DfE Design Manual – “Standards and guidance to help you design consistent, accessible, user-centred products and services in the Department for Education.”
design.education.gov.uk
DfE Accessibility Manual – Home and Standards sections (legal requirements and standards list)
accessibility.education.gov.uk
accessibility.education.gov.uk
DfE Architecture Manual – Table of contents (principles, standards, patterns, governance, profession)
dfe-digital.github.io
dfe-digital.github.io
DfE Design Histories – Purpose of design histories and example post listings
design-histories.education.gov.uk
design-histories.education.gov.uk
DfE Job Descriptions – Overview text and example of role categorization
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
Find and Use Standards – Site description and example standard detail (Accessibility Conformance)
standards.education.gov.uk
standards.education.gov.uk
DfE Technical Guidance – Introduction and example content (Technology Stack guide)
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
DfE User Research Manual – Introduction and excerpt showing standards and principles for UR
user-research.education.gov.uk
user-research.education.gov.uk
Apply the Service Standard – Site map showing Service Standard points and assessment pages
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
Accessibility Manual user research (blog post) – on reorganizing content for findability
accessibility.blog.gov.uk
accessibility.blog.gov.uk
Example of cross-manual navigation: Accessibility standard pointing to multiple manuals for guidance
standards.education.gov.uk






Sources
You said:
Ok, so don't cide sources within content. I'll be copying this out into a lucid board and it'll take me longer to strip out the sources. 

Use British english
ChatGPT said:
Understood – I’ll revise the full output using British English and remove all citation markers and footnote-style sourcing. The focus will be on clean, structured content ready for use in your Lucid board.

I’ll update the report accordingly and share the new version shortly.

Research completed in 16m · 28 sources · 24 searches
Information Architecture and Content Analysis of DfE Manuals and Guidance Sites

Information Architecture of DfE Digital Guidance Sites
Overview of the Existing Manuals and Sites
The Department for Education (DfE) currently maintains several separate manuals and guidance websites, each targeting a different aspect of digital service delivery or a specific professional community within DfE’s Digital, Data and Technology (DDaT) function. These include:
DfE Design Manual – A central repository of design standards, UI components, patterns, and guidance for user-centered service design
design.education.gov.uk
. It contains a Design System (with reusable styles, components, and design patterns)
design.education.gov.uk
, official Design Standards
design.education.gov.uk
, guidance on Content Design (e.g. style guide, plain language)
design.education.gov.uk
, and information for the Design Profession (e.g. a design skills framework, community meetups)
design.education.gov.uk
. It also features an “Our work” section (showcasing case studies or team projects) and a roadmap for evolving the design profession. The design manual is kept up-to-date with news posts (for example, new standards like a Plain Language standard
design.education.gov.uk
) and serves as a hub for design best practices in DfE.
Accessibility & Inclusive Design Manual – Guidance and standards to ensure DfE products are accessible and inclusive
accessibility.education.gov.uk
. Its IA is organized into sections for Accessibility Standards, Guidelines (practical how-to guidance, e.g. WCAG, inclusive design principles), Tools and Testing (e.g. assistive technology, testing methods), Audits, Issues and Statements (how to get an accessibility audit, manage accessibility issues, and produce legally required accessibility statements), Training, and a “Professions” section
accessibility.education.gov.uk
. This manual was iteratively designed based on user research – for example, an earlier “knowledge hub” page was split into clearer sections like Guidelines and Tools & Testing to match user expectations
design-histories.education.gov.uk
design-histories.education.gov.uk
. The Accessibility manual’s content is comprehensive (covering legal obligations like the Public Sector Accessibility Regulations
accessibility.education.gov.uk
, as well as common accessibility issues and solutions). It also provides role-specific accessibility guidance: the Professions section outlines what each digital role (e.g. content designer, product manager) needs to do for accessibility at each project phase
accessibility.education.gov.uk
. For instance, content designers get phase-by-phase accessibility checklists for discovery, alpha, beta, live
accessibility.education.gov.uk
accessibility.education.gov.uk
. This “what to do when” guidance by role is a unique aspect of the accessibility manual that could be expanded across other disciplines. The Accessibility site heavily links to shared standards; its Standards page references formal DfE accessibility standards (like Accessibility Conformance and Accessibility Statements) which are published in the central Standards catalogue
accessibility.education.gov.uk
.
Architecture Manual – A site documenting DfE’s architecture principles, standards, and patterns (hosted on GitHub Pages)
dfe-digital.github.io
. It serves technical architects and developers with high-level guidance to design services in line with DfE and government architecture best practices. The IA is structured into Principles (for different domains like business, data, enterprise, etc.)
dfe-digital.github.io
, Standards (architecture standards and definitions)
dfe-digital.github.io
, Patterns (reusable solution patterns such as integration and security patterns)
dfe-digital.github.io
, Governance (e.g. design governance processes)
dfe-digital.github.io
, and Profession (information on architecture roles, community, and capability framework)
dfe-digital.github.io
. There are also references to internal repositories and resources (e.g. links to SharePoint, Confluence) for deeper technical documentation
dfe-digital.github.io
. The Architecture manual complements other guidance – it explicitly points readers to the UK Government Service Manual and to DfE’s Technical Guidance site for implementation details
dfe-digital.github.io
. Some content in the architecture site overlaps with the Technical Guidance manual (for example, the Technical Architecture Principles link leads to the Technical Guidance site
dfe-digital.github.io
dfe-digital.github.io
), indicating a split between high-level architecture direction here and detailed technical standards in the other site.
Technical Guidance Manual – A comprehensive technical handbook for software development and IT operations in DfE
technical-guidance.education.gov.uk
. This site contains detailed Guides (how-tos on topics like setting up the DfE tech stack, developing APIs, continuous delivery)
technical-guidance.education.gov.uk
, Principles (covering general coding principles, data principles, security “Secure by Design” principles, frontend development principles, etc.)
technical-guidance.education.gov.uk
, specific Standards and conventions (for example, naming conventions, source code management, use of open source)
technical-guidance.education.gov.uk
, and extensive Infrastructure guidance (development tools, hosting and cloud setup, security practices like managing secrets, disaster recovery, monitoring, deployment automation, etc.)
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
. The Technical manual is geared toward internal developers/engineers (it even notes it’s intended for internal DfE use) and is kept in sync with evolving tools and platforms (e.g. Azure cloud details, DevOps tooling). Like the architecture site, it positions itself alongside other manuals – it explicitly says it complements the Service Standard guidance, Design Manual, Architecture manual, and the GOV.UK Service Manual
technical-guidance.education.gov.uk
. This indicates recognition that teams must consult multiple sources today. The technical content is detailed and high-quality, but it currently lives separately, which can require users to jump between this site and others for related topics (for example, a developer concerned with security might need to consult Technical guidance for coding practices and the Architecture manual for higher-level security patterns).
User Research Manual – A website for DfE user researchers that provides standards, principles, methods and community resources for user research
user-research.education.gov.uk
. The IA here includes sections for Community (information on the user research community of practice, meetups, Slack channels
user-research.education.gov.uk
), Your Career (guidance on career paths, joining DfE, training, mentorship, and progression for user researchers
user-research.education.gov.uk
user-research.education.gov.uk
), Standards (research-specific standards that all URs must follow – e.g. participant safeguarding, data handling in research, etc.
user-research.education.gov.uk
), Guidance (a library of research methods and best practices for planning and conducting research
user-research.education.gov.uk
), Templates and Tools (practical resources like templates, checklists, and tools to support research work), and Research Insight (potentially a repository of research findings or case studies). The User Research manual is quite holistic: it not only tells a researcher how to do their job (methods, ethics, inclusive practices) but also supports their professional development. For example, it links DfE’s user research roles to the standard government DDaT role descriptions and civil service grades
user-research.education.gov.uk
, and points to the Job Descriptions site for the official role descriptions of “User Researcher”, “Senior User Researcher”, etc.
user-research.education.gov.uk
. It also mentions a UR capability framework in development to map skills to roles
user-research.education.gov.uk
. The content here is up-to-date and tailored to the user research discipline, but like the design and accessibility content, it has interdependencies with other sources (e.g. it references the central DDaT framework on GOV.UK and uses job descriptions from the separate site).
Apply the Service Standard (Service Assurance Guidance) – A site dedicated to helping service teams meet the GOV.UK Service Standard within DfE
apply-the-service-standard.education.gov.uk
. Its structure is twofold: Service Standard guidance and Service Assessments process. The Service Standard section has a page for each of the 14 points of the UK Government Service Standard, explaining how to interpret and implement each in the DfE context
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
. This includes points on user needs, simplicity, accessibility, team composition, agile working, open source, appropriate technology, reliability, etc. Each point’s page provides DfE-specific guidance and links to relevant resources or examples. The Service Assessments section provides guidance on the assurance process DfE uses: it includes pages on how service assessments work, how to run a Discovery peer review or a full Service Assessment, how to report and manage actions, and how teams are supported through the process
apply-the-service-standard.education.gov.uk
. Essentially, this manual covers governance and assurance – ensuring teams know “what you need to do when” at each lifecycle stage to pass assessments and meet standards. There’s also a link to the Service Assessment Booking tool (“Service assessment service”) under “Services for teams” in the shared nav, indicating integration with the actual service assessment scheduling system
apply-the-service-standard.education.gov.uk
. The Apply the Service Standard site consolidates crucial governance content, but some of its guidance overlaps with or points to other manuals (for example, Standard 5 on accessibility will point teams to the Accessibility manual, Standard 11 on choosing technology will relate to architecture/technical standards, etc.). The content was last compiled in late 2022 (as evidenced by an Excel download of all guidance
apply-the-service-standard.education.gov.uk
) and is likely updated as policies change. This site is critical for delivery teams but currently stands alone; users often have to hop from a Service Standard point here to detailed guidance in another manual (e.g. for accessibility or technical specifics).
Find and Use Standards – A centralized catalogue of all DfE Digital, Data and Technology standards
standards.education.gov.uk
. This service acts as a standards registry where one can search or filter published standards by category (Architecture, Security, User-Centred Design & Accessibility, etc.)
standards.education.gov.uk
. Each standard is a formal policy or requirement (for example: Plain Language Standard, Digital Product Branding Standard, Data Protection, API Management, etc.), each with a reference code (DDTS-#) and a summary
design.education.gov.uk
standards.education.gov.uk
. The Standards site allows users to “Find a standard” (with filtering by domain), see Proposed standards (standards in development or under review), and even export all standards to Excel
standards.education.gov.uk
. It’s integrated into the content ecosystem: many manuals link directly to specific standards on this site (e.g. the Design Manual’s standards page lists the Plain Language and Digital Product Branding standards and links to their entries in the Standards repository
design.education.gov.uk
; the Accessibility manual links to Accessibility Conformance standards in the same way
accessibility.education.gov.uk
). The quality of content here is high in authority (these are official mandates), but from an IA perspective, the standards are detached from explanatory guidance. Users may find a requirement on standards.education.gov.uk, but have to navigate to a manual to understand how to implement it. Conversely, someone reading a manual will see references that jump out to the separate Standards site. This separation is a key point of fragmentation in the current state.
Job Descriptions Service – A “Find a job description” site providing standardized DfE job descriptions for DDaT roles
job-descriptions.education.gov.uk
. It’s organized by professional areas: for example, Architecture roles (11 architect roles listed)
job-descriptions.education.gov.uk
, Data roles (data engineers, data scientists, etc.), Software Development (e.g. DevOps roles)
job-descriptions.education.gov.uk
, User-Centred Design roles (Accessibility specialist, Content Designer, Interaction Designer, Service Designer, User Researcher)
job-descriptions.education.gov.uk
, and likely other categories such as Product and Delivery, Cyber Security, IT Operations, etc. Each category page lists the specific roles and links to detailed job description documents. The content on this site is essentially HR-focused templates, but it’s directly tied to the professions covered by the manuals. For instance, the User Research manual links out to these job descriptions for each UR role
user-research.education.gov.uk
, and the Architecture manual mentions roles that align with these descriptions (the Architecture “Profession” section is likely informed by the same role definitions). Each job description includes the role’s responsibilities and required skills, aligned to the Government DDaT Capability Framework (the site explicitly notes all roles align with the standard Government Digital & Data Profession capability framework
job-descriptions.education.gov.uk
). The quality of this content is standardized and authoritative (it ensures consistency in role expectations), but it exists on a separate site purely for lookup. In practice, someone working on capability or career development might need to use both the manuals (for guidance and skill frameworks) and this job description site (for formal role definitions). This is another area for potential consolidation or tighter integration.
Design Histories – A platform for sharing design case studies and project histories across DfE teams
design-histories.education.gov.uk
. It is essentially a collection of blog-like posts by various product teams, showing how services have evolved, design decisions made, research findings, and improvements over time. The site is organized by recency and by team/tags. The home page lists recent posts (with title, snippet, project name, and date)
design-histories.education.gov.uk
design-histories.education.gov.uk
 and provides a tag filter for topics (e.g. Accessibility, Data, Design Ops, Discovery, etc., reflecting the broad range of work)
design-histories.education.gov.uk
. Users can also view posts by team. The content type here is very different from the formal guidance in manuals – these are narratives and real examples (“Working in the open”). They provide contextual learning: for instance, a post might describe how the Support for Social Workers service improved an interaction pattern
design-histories.education.gov.uk
, or how a team conducted usability testing on navigation in the Accessibility manual
design-histories.education.gov.uk
. The design history entries are unique content (rich in practical insight and showing application of the guidance). However, they are somewhat siloed; the Design Manual home does promote Design Histories as a way to “find out how our services change over time”
design.education.gov.uk
, but otherwise the manuals and histories are separate systems. From an IA perspective, design histories act as supporting material or case studies for the manuals’ guidelines. Currently, one has to navigate to a different subdomain to read these examples. In a unified solution, these could be surfaced alongside relevant guidance (e.g. showing related case studies when reading about a pattern or standard).
Quality and Currency of Content: Overall, the content across these sites is quite rich and largely up-to-date in each domain. Many sections have been recently updated (for example, the Design Manual news and Accessibility manual updates in 2025 show active maintenance
design.education.gov.uk
design-histories.education.gov.uk
). The guidance often aligns with central government standards (GOV.UK Service Manual, GDS principles) while adding DfE-specific details. The main pain point is not the accuracy of content but findability and navigation – users can struggle to know which manual to consult or how to piece together guidance from multiple sites. As one user quote from research on the Accessibility manual navigation put it, “Think all content is there – I just struggled to find things.”
design-histories.education.gov.uk
. There is also some duplication or near-duplication: for instance, Standards are listed in individual manuals (Design, Accessibility, etc.) as well as in the central Standards registry, and certain topics like accessibility or service design principles appear in more than one place. The current IA spreads related content across silos, meaning users might “jump around manuals for guidance,” as you observed.
Common Structures and Overlapping Content
Despite the fragmentation, these products have common structural themes and content types. Identifying these overlaps is crucial for designing a unified information architecture:
Standards and Policies: Virtually all manuals reference formal standards that teams must follow. The Design Manual and Accessibility manual each have a Standards section that lists specific DfE standards (with identifiers) and links to the central Standards site
design.education.gov.uk
accessibility.education.gov.uk
. The User Research manual similarly lists standards (e.g. a Participant safeguarding standard) within its content
user-research.education.gov.uk
. Many of these standards (on accessibility, security, language, data, etc.) are stored in the Find and Use Standards service, making that a hub. This suggests “Standards” is a universal content type. In a new single manual, Standards could be a top-level category or filterable content type, so users can find any mandatory rule in one place (with explanatory guidance alongside, rather than in a separate silo).
Guidance and How-To Content: Each manual contains guidance documents — practical advice, best practices, and “how to” information. For example, the Design Manual has pages on content design (style guide, writing for accessibility)
design.education.gov.uk
, the Accessibility manual has detailed guidelines (like testing with assistive tools, inclusive design principles) after its recent IA iteration
design-histories.education.gov.uk
, and the User Research manual offers a guidance library on research methods
user-research.education.gov.uk
. Much of this guidance is narrative or instructional content aimed at helping teams meet the standards. There is overlap where guidance from different manuals intersects: accessibility is an obvious overlap (the Design Manual covers accessibility in design, the Accessibility manual covers it in depth, and the Service Standard point 5 also covers it). Similarly, user-centered design principles appear in Design, Accessibility, and Service Standard guidance. Agile delivery practices might appear in the Service Standard guidance (Standard 7) and in Technical/Architecture manuals (which advocate DevOps and continuous delivery). Currently, those overlaps are handled by cross-linking (e.g. a content designer following the accessibility guidance is pointed to Service Standard #5 and to GOV.UK resources
accessibility.education.gov.uk
). In a unified site, these related guidance pieces can be consolidated or at least presented in a cohesive way (e.g. one comprehensive guidance section for “Inclusive design” that combines what is now spread across design, accessibility, and service standard sites).
Patterns, Components and Reusable Solutions: The concept of reusable solutions appears in multiple places. The DfE Design Manual provides UI design patterns and components (via the design system)
design.education.gov.uk
. The Architecture manual defines technical patterns (integration patterns, security patterns, etc.)
dfe-digital.github.io
. The Service Standard explicitly calls out “use and contribute to open standards, common components and patterns” (point 13)
apply-the-service-standard.education.gov.uk
, which ties back to both design system components and architectural/common tech components. This indicates that “Patterns & Components” is a content type that spans design and technology. Currently, a user might have to visit the Design System for front-end patterns and the Architecture site for backend/integration patterns. A unified IA could have a single Patterns library that is filterable by domain (UI, technical, data, etc.), or at least a clearly integrated set of pattern catalogs. All patterns share a goal: enabling consistency and reuse in building services.
Principles and Best-Practice Tenets: Many manuals articulate high-level principles. For instance, the Design Manual references the GOV.UK Design Principles and DfE design principles (through its standards and external links)
design.education.gov.uk
. The Architecture Manual has sections for principles in various sub-domains (business, data, identity, etc.)
dfe-digital.github.io
. The Technical Guidance lists coding and design principles (like “Secure by Design”)
technical-guidance.education.gov.uk
. The User Research manual outlines community principles for conducting great research
user-research.education.gov.uk
. These are all essentially “Principles” content type – concise, enduring guidelines that underpin decisions. While the specifics differ by field, they overlap conceptually (e.g. both design and development have a principle of working in the open and user-focused). In a single manual, principles could be presented in one section or tagged by domain, ensuring all fundamental tenets (design, technical, research, data, etc.) are accessible without hopping sites.
Lifecycle/Process Guidance (“What to do when”): A key overlapping need is guiding teams through phases of delivery (Discovery, Alpha, Beta, Live) and governance steps. The current content addresses this in pieces:
The Apply Service Standard site is essentially stage-wise guidance aligned to lifecycle gates (e.g. before a Beta assessment, ensure points 1–14 are met; for Discovery peer review, follow certain steps
apply-the-service-standard.education.gov.uk
).
The Accessibility manual’s Professions section explicitly breaks down what each role should do at each project phase
accessibility.education.gov.uk
accessibility.education.gov.uk
 – this is an excellent example of phase-based guidance.
Other manuals hint at phases (e.g. research guidance might distinguish activities in Discovery vs. Beta, design process might differ from discovery to live).
There is also governance content scattered around: the Architecture manual references governance (likely design review boards or architecture approvals)
dfe-digital.github.io
, and Technical guidance touches on processes like continuous delivery (which is lifecycle-related).
This suggests a unifying content dimension of “stage-based guidance”. In a consolidated manual, we might have a section or an interactive guide for “Project lifecycle & governance” that tells users what needs to happen regarding design, research, accessibility, technical architecture, security, etc., for each phase of a project. This would directly address the pain point of jumping between manuals – currently one might need to consult the Service Standard site for overall requirements, the accessibility manual for accessibility-specific tasks, and the design manual for design tasks in, say, Alpha. A unified approach could aggregate these by phase. (For example, an Alpha phase page could list: conduct usability testing (link to UR manual), refine prototypes using design system (link to design manual), run an architecture review (link to architecture guidance), complete an accessibility checkpoint audit (link to accessibility guidance), etc.).
Professional Communities and Career Development: Several manuals contain content for building the profession:
The Design Manual has pages about the design community: DesignOps support, working groups (for design system, content style)
design.education.gov.uk
design.education.gov.uk
, meetups and events, and the Design Skills Capability Framework
design.education.gov.uk
 which outlines competencies for various designer levels.
The User Research Manual dedicates a whole section to “Your career” in UR, covering induction for new starters, mentoring, training, and how roles map to grades
user-research.education.gov.uk
user-research.education.gov.uk
.
The Job Descriptions site (while separate) is essentially supporting this by providing the standardized role definitions for each profession (design, research, technical, etc.). Likewise, the manuals often reference the DDaT Profession Capability Framework on GOV.UK for alignment
job-descriptions.education.gov.uk
.
There are also community forums: e.g. Slack channels mentioned for Accessibility and DesignOps support
accessibility.education.gov.uk
design.education.gov.uk
.
The common thread is Profession & People content – aimed at the individuals in these roles and their growth, rather than directly at building a service. In the new manual, it would make sense to have a unified “Working in DfE Digital” or “People & Community” area. This could host:
Role guides & career paths: possibly unifying the capability frameworks and linking to job descriptions, so one place describes all DfE digital roles and what progression looks like (instead of each manual doing it separately).
Community resources: such as lists of communities of practice, working groups (for design, research, engineering, etc.), events calendar, and how to get support (DesignOps, ResearchOps contacts, etc.). Currently, these are sprinkled in different manuals’ “Profession” or “Community” sections
accessibility.education.gov.uk
design.education.gov.uk
.
Training & onboarding: e.g. the accessibility manual points to training, UR manual lists training and mentoring, etc. These could be consolidated into a single training resource center for all DDaT professions, potentially with filters by profession.
Tools, Templates and Resources: Many manuals list helpful tools or templates:
Accessibility has Tools & Testing (e.g. color contrast checkers, screen reader tools, and when to use them)
design-histories.education.gov.uk
.
User Research has Templates and Tools (likely including templates for discussion guides, consent forms, etc., and tools for recruitment or analysis).
Design Manual’s DesignOps section likely points to tools for design (Figma libraries, prototype kits) and the Design System itself is a “tool” for designers.
Technical Guidance includes references to developer tools and platforms (GitHub, Azure DevOps, monitoring tools)
technical-guidance.education.gov.uk
.
All of these can be seen as a Resource Library that could be unified. In the new IA, a section for “Tools & Templates” could let users browse all resources, or filter by category (e.g. Design tools – link to Figma kit, design history how-to; Accessibility tools – link to assistive tech list and testing instructions; Research templates – link to interview script template; Code tools – link to GitHub guidance or code templates). This would prevent the need to know which manual holds the template you need.
Case Studies and Examples: Only the Design Histories site currently provides narrative case studies, but within the manuals there are often examples or links to examples (for instance, Accessibility guidance might link out to a design history post or to an example of an accessible service). Overlapping content type here is “examples / case studies / histories.” In a unified setup, these could be treated as supporting content that is contextually linked. For example, when reading the guidance on “designing accessible forms,” the page could show a sidebar with “Related design history: How Service X improved form accessibility (link)”. There could also be a dedicated “Case Studies” section aggregating all design histories in one place for learning by example (instead of being solely chronological as now).
In summary, the manuals share many content types – Standards, Guidelines, Patterns, Principles, Processes, Roles, Community info, Tools, and Case studies – but each manual currently implements a subset in its own silo. This leads to redundancy (e.g., separate lists of standards or separate career guides) and a disjointed user journey when a topic spans multiple domains. A user often has to manually traverse from one site to another via cross-links (the nav bars help by listing other manuals, but that is a workaround rather than seamless integration).
Unique Content and Structure in Each Product
While much can be standardized, it’s important to note unique elements that will need special treatment in a unified architecture:
Design System (Components and Styles): The Design Manual’s Design System pages (styles, components, patterns) are a distinct content set
design.education.gov.uk
. They function as a reference library for UI designers and front-end developers, often with live examples and code snippets. This kind of content is more interactive and reference-like compared to narrative guidance. In a single manual, the design system would likely remain a distinct section or even a separate mode (since it might be maintained via a different platform or needs versioning). However, its existence should be integrated (e.g. patterns from the design system referenced in relevant guidance about designing interfaces). No other current manual has this equivalent (though the technical manual has some code standards, it’s not a component library). Unique challenge: ensuring the unified site can technically accommodate the design system’s content (possibly by embedding or linking out if needed). From an IA perspective, “Components & Patterns” remain an important top-level category for front-end design resources.
Job Descriptions Database: The job descriptions site is a unique content repository – essentially a database of role profiles. In a new manual, these could be pulled in as pages or a dynamic lookup. It may not make sense to keep it a separate site; instead, those descriptions could live under a “Roles” or “Careers” section. However, their structured nature (they likely have a consistent template format) should be preserved. Unique content type: “Job Description” – which includes fields like role purpose, responsibilities, skills, mapped to a grade. These could potentially be combined with the capability framework content so that users see both the formal description and expectations by skill area. Currently, no other manual has that structured HR content except references to it.
Service Assessments Process Content: The Apply the Service Standard site contains detailed process guidance for assessments (how to run them, report, manage outcomes) that doesn’t appear elsewhere
apply-the-service-standard.education.gov.uk
. This content is quite specific (and tied to DfE’s internal processes and tools). In a unified manual, this would form the core of a “Governance & Assurance” section. It is unique in that it’s process documentation rather than static guidelines (e.g., it might include step-by-step instructions for assessors or service managers). Also, it ties into an actual service (the booking tool). Care must be taken to keep this content prominently accessible, since it’s critical for teams reaching those milestones. It might remain largely as-is, but integrated with other lifecycle content (e.g., a team in Beta phase would need to know about preparing for a Beta assessment – linking these process pages with the lifecycle guidance would be beneficial).
Design Histories (Team Blogs): As discussed, these are unique in format and tone. They are currently in a separate platform optimized for blogging. In a consolidated IA, one might not import all historical posts into the main site’s CMS (that could be huge), but rather aggregate or tightly link them. Perhaps the unified site could feature an embedded feed or curated examples, while the bulk of the design history content stays in a repository. The IA should ensure the insights from these histories inform guidance (e.g. via “related posts” or quotes) to enrich the manual. The existence of the Design Histories site is a unique strength (few departments have such a rich archive of lessons learned), so the new manual should leverage it even if it remains technically separate. At minimum, case studies should be recognized as a content type in the model.
Cyber Security Content: Although not explicitly listed in your question, the navigation menus list a Cyber and Information Security site (cyber-security.education.gov.uk)
design.education.gov.uk
. If your team manages this as well, note that it likely contains security-specific standards and guidance (e.g. secure development, managing cyber risks) similar to other manuals. If included, it would overlap with technical/architecture content (security principles, standards) but also have unique content around security operations, incident response, etc. In a unified manual, Security might become a content category under technical or assurance sections. (If the cyber content is out of scope for now, it can be integrated later – but it’s worth mentioning as part of the full landscape.)
Content Quality and Style Differences: Each manual was developed somewhat independently, so there are slight stylistic differences. For example, the User Research manual has a more conversational, community tone (with Q&A, job postings section
user-research.education.gov.uk
), whereas the Standards repository is very matter-of-fact and terse. The design manual has a promotional front page with news and highlighted links
design.education.gov.uk
, whereas the technical guidance just dives into a menu of topics. When unifying, we will need to standardize the tone and UX – likely adopting a consistent GOV.UK-style voice, but allowing some flexibility for community sections. It’s important to maintain the high quality of content while making it feel part of one site. This may involve editing some content for consistency and updating any outdated references (for example, ensuring the last-updated info is visible so users trust it’s current).
Toward a Unified Information Architecture – Standard Content Types
Based on the above, we can propose a set of standard content types and structural elements for the new single manual. These would encompass all the overlapping and unique content in a consistent model:
Standards: Formal, version-controlled requirements that must be followed (each mapped to categories like security, accessibility, etc., and owning team). In the new IA, all DfE DDaT standards can live in one “Standards” section or database, replacing the need for a separate standards site. Users could browse or search standards (much like the current Find and use standards service)
standards.education.gov.uk
, but within the manual. Crucially, each standard can be linked to explanatory guidance. For example, a standard like “Plain Language” would be listed under Standards (with its ID and summary)
design.education.gov.uk
, but also the Content Design guidance page can directly include its key points or link to it for details. Standard content type will include fields like title, ID, summary, and full text or link to policy source.
Guidance: The core how-to documents providing advice, best practices, and procedures. This is a broad type that may be segmented by topic or discipline. For instance, within Guidance you might have sub-categories or tags: Design Guidance, Accessibility Guidance, Research Guidance, Technical Guidance, Content Design, Security Guidance, etc. All current narrative pages (like “How to do X”, “Guidelines for Y”) fall here. We will likely implement this as a library or knowledge base section. Each guidance page should be labeled with relevant tags (e.g. a page about “Writing accessible content” might be tagged as both Content Design and Accessibility). This way, users can navigate by topic or by role need. Importantly, guidance pages will reference standards (and vice versa). They will also be mapped to lifecycle stages where appropriate. For example, a “Usability Testing in Beta” guidance might be tagged under both “User Research guidance” and “Beta phase”.
Patterns & Resources: A type encompassing reusable solutions and assets. This can be split into:
Design System Components/Patterns: each pattern or component page (with usage guidance and code) – these could remain a distinct subcategory, but logically they are a type of guidance specifically for UI implementation. We might treat them as a special subset of guidance with a code example field. In the IA, “Design System” could be a top section due to its importance for designers and developers, but it would be cross-referenced in relevant guidance (for example, a general form design guidance page would link to specific form component patterns).
Technical Patterns/Playbooks: e.g. integration patterns, code templates, or architecture reference models. These could be included under a “Technical Library” or similar section. They may have a structure (problem -> solution pattern -> when to use, etc.). Currently in the architecture manual
dfe-digital.github.io
.
Tools and Templates: actual resources that teams can use – for example, checklist templates (in Word/Excel), design sketch files, research consent form templates, etc. These could be stored as downloads or links. Each tool resource could be its own content type with metadata (what it’s for, format). In the unified site, we might have a “Tools & Templates” repository that users can filter by category (design, research, project management, etc.). This prevents scattering these links in prose across manuals; instead, a central listing with contextual links out from guidance pages (e.g. a guidance page on “Writing an accessibility statement” would link to the accessibility statement template resource).
Role Profiles and Career Paths: A content type for “Role” or “Profession” information. Each role (e.g. “Senior Interaction Designer”, “Data Architect”, “User Researcher”) would have a page combining the standard job description (responsibilities, skill requirements) and possibly additional info like typical tasks, links to relevant guidance for that role, and career progression tips. These could pull from the existing Job Descriptions content
user-research.education.gov.uk
 and be enriched with manual content (for example, linking to the skill framework or mentoring info). Additionally, a top-level “Careers in DfE Digital” section can introduce how the professions map out, the capability frameworks, and links to current vacancies or hiring processes (the UR manual had a small feed for job vacancies
user-research.education.gov.uk
 that could be generalized). By standardizing the Role content type, we ensure that whether someone is a designer, developer, researcher, etc., they can find both the formal definition and the tailored guidance (like the accessibility “what to do” checklists by role) in one place. This addresses the DDaT professions aspect, ensuring the manual supports the DDaT Profession Framework and skill development.
Lifecycle/Phase Guides: As discussed, a likely new structure will be to have content organized by service lifecycle stage. This might be implemented as a set of pages or an interactive wizard for Discovery, Alpha, Beta, Live (and perhaps idea/initiation). Each phase page would compile what activities, checks, and standards apply in that phase. It could be an aggregation of links (e.g. “In Discovery, ensure you… conduct exploratory research [link], draft a high-level architecture outline [link], consider accessibility early [link to relevant guidance], and prepare for a discovery review [link].”). This is not a content type per se (since it will borrow from guidance/standards content), but a navigational scheme. However, each “Phase” page can be considered a unique content piece in the IA. It directly addresses the “what you need to do when” pain point by providing a time-based pathway through the content.
Governance Processes and Checklists: Related to lifecycle, but specifically the governance/assurance content. This includes how to engage with architectural governance (design approval boards, etc.), how to use the Service Assessment process, compliance checklists (for accessibility, security, data protection at various stages). We might define a content type for “Process” or “Checklist”. For example, “How to get an Accessibility Audit” is a process page (currently in the Accessibility manual as a popular page
accessibility.education.gov.uk
), as is “Run a service assessment”
apply-the-service-standard.education.gov.uk
. These procedural pages often list steps 1, 2, 3… and have responsible roles. In a unified site, we could group these under an Assurance or Governance section, or tag them clearly. Standardizing them means writing them in a consistent step-by-step format. By doing so, users tasked with compliance can find all required processes without jumping around.
Community and Support Information: Content that tells users where to get help or collaborate. This includes:
Communities of Practice info (e.g. “Design Working Group”, “UR Community Slack #channel”) – currently found in multiple places
accessibility.education.gov.uk
design.education.gov.uk
. We can create a listing of all communities and working groups in one section, possibly under “Community”.
Support contacts (like the DesignOps team support page
accessibility.education.gov.uk
 or “Who to contact for Accessibility guidance”) – these can be consolidated into a “Support” page that triages queries by topic.
Events/Meetups calendar – the Design manual’s Meetups page
design.education.gov.uk
 and any other event info could feed into a unified events list. If maintained, a dynamic feed of upcoming events by profession could be offered.
We might treat this as a content type “Announcement/Event” if needed, but at minimum a page listing recurring meetups and linking to the cross-government ones (Slack, etc.).
News and Updates: The Design Manual currently surfaces news articles on its homepage
design.education.gov.uk
. It’s possible other manuals announce new standards or changes via blog posts or design history posts. In a single manual, it might be useful to have a News or “What’s New” section to communicate updates (e.g. “New standard published: X” or “Updated guidance on Y”). This would help drive engagement and signal content freshness. These could be short news items (a lightweight content type). Alternatively, design histories could serve that role (but those are more in-depth). A unified news section could replace the scattered news in individual sites.
By establishing these content types, we can also identify what can be standardized versus what remains unique:
Standardize: things like Standards, Guidance pages, Process docs, Role descriptions, etc., can have a consistent format and live in one site. For example, all standards share a template with fields for summary and categories, and all guidance pages follow a style guide (using GOV.UK style for headings, short paragraphs, lists, etc., per your formatting requirements).
Unique but Integrated: the design system might remain a distinct managed section, but integrated in navigation and cross-references. Design histories might remain on their platform but surfaced via links/previews.
Navigation: The new IA should present multiple intuitive ways to find content – by role (profession), by topic (category/tags), by lifecycle stage, and by search. This is critical to reduce the confusion. Currently, the navigation is primarily by manual (silo) and within each manual by its own scheme. The new single site can introduce a more user-centered navigation structure:
A user could navigate by “I am a [role]” (bringing them to a curated view of content for that role),
Or “I need to…” (e.g. design a new service, conduct research, prepare for assessment – which maps to tasks and thereby to content),
Or “Stage: [Discovery]” (to see all requirements/guidance at that stage).
These approaches can be facilitated by the content model above (with proper tagging and organization).
In terms of pain points resolution: Consolidating into one manual with these standardized content types directly addresses the main pain point you mentioned. Instead of jumping between separate manuals, users will have one platform where all content is interlinked. For instance, if they search for “accessibility,” they’ll get the relevant standard, guidance, tools, and roles in one place. If they are a service owner in Beta, a single Beta checklist page will point them to all relevant actions (design, technical, research) with deep links to detailed guidance. Finally, aligning on these content types helps ensure nothing important is lost in the merge. Each existing site’s content can be mapped to one (or more) of the new content categories. Overlapping content can be merged (for example, if both the Design and Accessibility manuals had an “accessible language” guide, those can be unified into one definitive guide). Unique content will be preserved under the appropriate section (e.g. the job descriptions become role pages; the architecture principles merge into an overall principles section, etc.). The outcome will be a single, comprehensive DfE Digital Manual that improves usability and coherence, while covering all the needs previously met by the multiple sites – from high-level principles down to practical checklists. Sources:
DfE Design Manual – navigation and content structure
design.education.gov.uk
design.education.gov.uk
design.education.gov.uk
Accessibility & Inclusive Design Manual – structure and role-based guidance
accessibility.education.gov.uk
accessibility.education.gov.uk
accessibility.education.gov.uk
DfE Architecture Manual – documented sections (principles, standards, patterns, etc.)
dfe-digital.github.io
dfe-digital.github.io
DfE Technical Guidance – scope and relationship to other manuals
technical-guidance.education.gov.uk
technical-guidance.education.gov.uk
User Research Manual – structure and integration with roles and standards
user-research.education.gov.uk
user-research.education.gov.uk
Apply Service Standard – service standard points and assessment content
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
Find & Use Standards – purpose as central standards repository
standards.education.gov.uk
standards.education.gov.uk
Job Descriptions – categories of roles and link to capability framework
job-descriptions.education.gov.uk
job-descriptions.education.gov.uk
Design Histories – example of content and navigation research findings
design-histories.education.gov.uk
design-histories.education.gov.uk






Sources
You said:
Lets work on the content around "Toward a Unified Information Architecture – Standard Content Types"

Lets define these a bit better, using examples from GOV.UK Style Guide and Content Types to help define what pages might look like, need, and interconnect within a much larger IA
ChatGPT said:
Great — to define the standard content types more precisely, could you confirm a few details so I can tailor the analysis accordingly:

Would you like me to focus on GOV.UK style guidance specifically (e.g. from the GOV.UK Content Design Guide, Service Manual, Design System) or also include examples from related departments or arms-length bodies?

Should the content type definitions include page structure (e.g. headings, layout, examples of how guidance and standards interlink), or focus more on metadata and tagging models?

Are you aiming for a model that supports both web content and structured CMS authoring (e.g. headless CMS fields), or mainly for information architecture and page design?

Once I have this, I’ll define each content type (like Guidance, Standard, Pattern, etc.) using GOV.UK conventions and propose example page structures, relationships, and potential reuse models.

You said:
We'll probably be using Strapi as a CMS to support the new Service Manual So some aspect of content modelling is needed. 

What I'm looking for is definitions and fields and usage for different page types based ln what we have
ChatGPT said:
Thanks – I’ll define standard content types suitable for a unified DfE Service Manual, using GOV.UK content design conventions and examples, and factoring in Strapi CMS modelling needs.

I'll outline each content type with a definition, suggested fields (for Strapi), guidance on usage, relationships to other types, and example page structures to support navigation and clarity at scale. I’ll let you know once it's ready.

Research completed in 16m · 18 sources · 23 searches
Standard Content Types for a Unified DfE Service Manual

Content Model for a Unified DfE Service Manual
The unified Department for Education (DfE) Service Manual will bring together standards, guidance, patterns, and other resources from multiple existing manuals into one structured system. This unified model will reduce duplication, allow clear tagging and cross-linking of content, and make it easier for teams to find what they need. All content types and page structures follow GOV.UK style and content design conventions for clarity and consistency. The content types below are defined in plain English, with their purpose, structure (suggested fields in a Strapi CMS), and how they relate to each other in the manual ecosystem.
Standard
Definition: A Standard is a mandatory rule or requirement that DfE teams must follow. It ensures consistency, accessibility, security, and quality across digital services. For example, DfE’s accessibility standards are requirements all products and websites must meet
accessibility.education.gov.uk
. Standards often implement legal or policy obligations (such as accessibility regulations) and set the baseline for good practice. Primary use cases:
Used by delivery teams to understand the rules they need to comply with (e.g. a development team checking security standards).
Used by assurance/governance teams to assess whether a service meets DfE and government requirements.
Serves as a reference for designers, developers, and product managers to ensure their work aligns with DfE’s required practices.
Key fields/attributes: (for Strapi CMS modeling)
Title – Name of the standard (plain language).
Slug – URL-friendly identifier (e.g. “plain-language”).
Reference code – An optional code or ID (e.g. “DDTS-529”) for internal tracking
standards.education.gov.uk
.
Version – Version number of the standard (for versioned updates)
standards.education.gov.uk
.
Publication dates – Published date and last updated date
standards.education.gov.uk
.
Summary – A short description of the standard’s intent (1–2 sentences, plain English)
standards.education.gov.uk
.
Body content – Rich text content of the standard, structured with recommended sections:
Purpose: why this standard exists and the problem it addresses
standards.education.gov.uk
standards.education.gov.uk
.
How to meet this standard: specific actions or criteria teams must follow to comply
standards.education.gov.uk
standards.education.gov.uk
.
When to meet this standard: scope or timing (e.g. which projects or lifecycle phases it applies to)
standards.education.gov.uk
.
Declaring conformance: (if applicable) how teams formally show they meet the standard.
Categories/Tags – Taxonomy linking the standard to thematic categories or domains (e.g. “Security”, “User-Centred Design”)
standards.education.gov.uk
standards.education.gov.uk
. This helps users filter standards by topic area.
Related guidance links – Links to Guidance or Pattern pages that help teams implement the standard (for example, a “Plain Language” standard may link to writing guidance)
standards.education.gov.uk
.
Owner – The person or team that owns the standard (name and role), and contact for queries
standards.education.gov.uk
.
Approval/Status – (If needed) field to indicate if the standard is approved, under review, or proposed (e.g. a boolean or status field; note that DfE already distinguishes “Standards” vs “Proposed Standards” in the standards hub).
Version history – (If using versioning) previous versions or change log of the standard.
Page structure guidance: A standard page should begin with a clear summary of the requirement. Use headings to break down content into logical sections (as listed in fields). For example, many standards include Purpose, How to meet this standard, and When it applies as H2 headings to guide readers
standards.education.gov.uk
standards.education.gov.uk
. Use plain English, short sentences and bullet points for criteria or actions (following GOV.UK style for clarity
standards.education.gov.uk
). Include a call-out or “You must…” phrasing for any non-negotiable rules. At the end, provide owner and contact information and a feedback prompt (e.g. “Tell us what you think of this page”) per GOV.UK conventions
standards.education.gov.uk
standards.education.gov.uk
. If relevant, include a table of contents for longer standards to improve navigation
standards.education.gov.uk
. Interconnections: Standards should be heavily cross-linked with other content types to put them in context. For example:
A Standard can link to Guidance pages or Tools that help meet it (the “Plain Language” standard links to writing guidance and style guides
standards.education.gov.uk
standards.education.gov.uk
).
Standards are tagged by category or profession, which allows users to find all standards related to a topic (e.g. filtering standards by “User-Centred Design and Accessibility” shows relevant ones
standards.education.gov.uk
standards.education.gov.uk
).
Standards often support external frameworks like the GOV.UK Service Standard – linking to the relevant Service Standard point if applicable
standards.education.gov.uk
.
Within the manual, Guidance or Patterns pages will reference the Standards they help achieve, creating a two-way linkage.
Governance notes: Each standard has a clear owner responsible for its accuracy and updates (e.g. Head of Profession or subject matter lead)
standards.education.gov.uk
. Changes to standards should go through an approval workflow (for example, a Design Authority or Architecture Board may approve new standards). Using version fields, the CMS can handle versioning, so updates don’t erase history – this aligns with having “Published” dates and version numbers displayed
standards.education.gov.uk
. It’s recommended to mark whether a standard is mandatory and if teams must formally attest compliance (possibly via a “declaring conformance” process, which can be described on the page). Governance processes (like periodic review dates or a proposal process for new standards) should be documented, possibly in a Proposed Standards section for transparency
standards.education.gov.uk
standards.education.gov.uk
.
Guidance
Definition: Guidance pages provide practical advice, how-tos, and recommended best practices to help teams implement standards or carry out their work effectively. Guidance is written in plain English as step-by-step instructions or explanatory content, aligned with GOV.UK content design principles. Unlike standards, guidance is not mandatory rules but recommendations and support information for teams. For example, technical guides on continuous delivery or accessibility testing are guidance that complement the mandatory standards
technical-guidance.education.gov.uk
accessibility.education.gov.uk
. Primary use cases:
Used by team members (designers, developers, researchers, etc.) looking for how to do something correctly in DfE (e.g. “How to conduct user research with children” or “Guide to cloud deployment in DfE”).
Provides interpretation of standards, showing how to meet them in practice (e.g. guidance on meeting accessibility criteria or content design guidance to meet the Plain Language standard).
Serves as training material or reference for new staff or communities to learn DfE-specific processes and good practice.
Key fields/attributes:
Title – Descriptive title of the guidance (e.g. “How to get an accessibility audit”). Titles should clearly indicate the task or topic.
Slug – URL slug for the page (e.g. “getting-accessibility-audit”).
Summary/introduction – A brief intro outlining what the guidance covers. This could double as the meta description and appears on listing pages.
Body content – The main content, typically structured in logical sections with clear headings. Depending on the topic, structure might include:
Overview or Purpose: why this guidance matters or when to use it.
Step-by-step instructions or key points: use ordered or unordered lists for sequences (for example, an audit process, a how-to procedure). Each step should be short (1-3 sentences) for scannability, following GOV.UK style of concise instructions.
Examples or Scenarios: if applicable, illustrate with examples (e.g. example of a good accessibility statement, or sample code snippet in technical guidance).
Tools or templates referenced: if the guidance involves using a tool or completing a template, mention and link to those (possibly in a “What you will need” section).
Further reading/Related content: additional resources or related manual pages.
Tags/Topics – Tags for relevant topics, phases, or roles (e.g. a guidance page on “API development” might be tagged under “Technical” and “Architecture”). This helps in filtering or grouping guidance by subject area.
Related standards – (Optional field or just in content) reference to any Standard that this guidance helps to fulfill. For instance, guidance on “Writing for GOV.UK” would relate to a content design standard.
Related patterns/tools – (Optional) link to any design patterns or tools that are mentioned in the guidance.
Owner/Contributor – The person or team who curates the guidance (could be a role like “Technical Architect team” or an individual). Not always displayed prominently, but useful for governance.
Last reviewed – Date of last review/update (to encourage regular maintenance of guidance).
Page structure guidance: Guidance pages should follow a consistent, user-friendly format. Start with a short introduction that tells the reader what the guidance will help them do, in clear terms. Use meaningful subheadings for each section of the task or topic so users can scan for relevant info
design.education.gov.uk
. When listing steps or recommendations, use bulleted or numbered lists for clarity, as per GOV.UK style (for example, a guide might have “Step 1: Do X” as an H3 and sub-bullets underneath). Ensure paragraphs are brief (no more than 3-4 sentences) and use active voice and present tense (“Do X”, “Check Y”). Include call-out tips or notes for important points or common pitfalls (these could be styled differently by the design system, but authored as part of content). If guidance is long, enable an autogenerated contents list at the top for easy navigation (like many standards/guides do)
standards.education.gov.uk
. At the end, optionally have a “Related content” list linking to related guidance, tools, or standards (as seen in some news and guidance pages
design.education.gov.uk
). Also consider a feedback component (standard across manual pages) inviting suggestions or indicating if content was useful. Interconnections: Guidance is the glue connecting standards, patterns, and practical application:
A Guidance page often links out to Standards it helps to implement (for example, “guidance to meet the standard” links in a news article refer to specific guidance pages
design.education.gov.uk
). In the CMS, you might have a field to associate relevant standards.
Guidance pages can link to Pattern pages or the Design System if they discuss using specific UI patterns (e.g. a content design guidance might link to a design system pattern for content hierarchy).
They may reference Tools or Templates that readers can use (e.g. linking to an Excel template or an internal tool for performance analysis).
Tagging with Lifecycle stages or roles: If certain guidance is particularly relevant in Discovery phase or for a certain profession, it can be tagged accordingly. For instance, “How to run a discovery user research session” would be tagged with Discovery and User Research so that someone filtering content by the Discovery stage or by the User Research profession finds it easily.
The manual should allow multiple guidance pages to be grouped or sequenced. For example, the “Apply the Service Standard” section breaks down guidance by each point of the service standard
apply-the-service-standard.education.gov.uk
. Those pages are guidance pages linked in sequence (1 through 14).
Guidance often needs to be accessible from various entry points (search, navigation, related links), so ensure cross-links where appropriate (e.g. technical guidance linking to architecture principles
technical-guidance.education.gov.uk
, and vice versa).
Governance notes: Guidance content should have clear ownership by subject matter experts (for example, a “Content Design Guidance” might be owned by the Content Design Lead, technical guides by the Architecture team). Owners are responsible for keeping the guidance up-to-date (especially as standards or tools evolve). We recommend implementing a review cycle (perhaps a “Next review date” metadata) to prompt updates. Unlike standards, guidance can be more quickly iterated, but it should still undergo review for accuracy and adherence to style. All guidance should align with the GOV.UK Content Design guidance for tone and clarity, meaning content designers or editors should review it for plain English, active voice, and user focus. Governance might also include an approval step for publishing new guidance (for consistency across the manual). If using version control, major changes can be noted, but typically a simple “last updated” stamp is sufficient.
Pattern
Definition: A Pattern is a reusable design solution or best practice approach to solve a common user problem. In the context of the DfE Service Manual, patterns often refer to user interface design patterns or recurring solutions in service design (they could also include architectural or process patterns). Patterns describe how to do something in an optimal way, often accompanied by examples or components. According to the GOV.UK Design System, “Patterns are best practice design solutions for specific user-focused tasks and page types”
design-system.service.gov.uk
, each supported by guidance and examples. Primary use cases:
Used by designers and front-end developers to implement consistent UI/UX across services (e.g. a pattern for form design or an interaction pattern for asking for user data, ensuring it’s consistent with GOV.UK style
design-system.service.gov.uk
).
Used by service designers or business analysts for recurring process patterns or service patterns (like common onboarding flows).
Helps teams new to DfE or GOV.UK understand what established approach to use (reducing the need to “reinvent the wheel”).
Provides a basis for reusability – patterns often link to code (components) or template content that can be directly reused.
Key fields/attributes:
Title – Name of the pattern, phrased by the user need or problem it addresses (e.g. “Ask users for addresses” or “Single sign-on pattern”).
Slug – URL slug (e.g. “ask-for-address”).
Summary – Brief description of what the pattern is and when to use it (one or two sentences). For instance, “Best practice for collecting a postal address from a user, ensuring all necessary fields are captured.”
Problem statement/Use when – (Structured field or heading in body) Explains the scenario or user task the pattern is for. Essentially: “Use this pattern when… (e.g. when you need to collect an address for delivery).”
Solution details – This is the main body content describing how the pattern works. Could include:
Design guidance: how to layout or structure the interaction (e.g. for a form pattern, how to order fields, what language to use on labels).
User experience considerations: accessibility and usability notes specific to this pattern (making sure it works for all users).
Examples: one or more example implementations. Often this might include screenshots or code snippets if UI-related. In a structured CMS, examples might be handled via an embedded code or image field.
Do’s and Don’ts: bullet points listing good vs bad implementation (if applicable, following GOV.UK Design System style for pattern guidance).
Components/Resources – If the pattern uses specific design system components or code packages, list them (e.g. “Uses GOV.UK Design System components: Address input, Text input, etc.”). This could be a list of references to components or just mentioned in text
design-system.service.gov.uk
.
Related guidance – Links to any written guidance that supports the pattern (for example, a content style guide entry or research evidence for the pattern). The Design System notes that all patterns are supported by written guidance
design-system.service.gov.uk
, so in our CMS model we might have a field to associate a “guidance page” or a rich text section to provide that guidance.
Tags/categories – Categorize patterns by type (e.g. “form pattern”, “navigation pattern”, or broader categories like “User-Centred Design” or “Security patterns”). In the architecture context, there might be categories like “Integration patterns” or “Security patterns”
dfe-digital.github.io
.
Lifecycle applicability – (Optional tag) If a pattern is specific to a phase or context, e.g. a “Discovery research pattern” vs a “Live service pattern”. Usually UI patterns are phase-agnostic, but architectural patterns might be noted for certain stages.
Owner/Status – Who maintains the pattern (e.g. the DfE Design Ops or a Design System team). Also whether the pattern is DfE-specific or adopted from GOV.UK. For instance, if a pattern is still experimental or “proposed” for inclusion, that could be indicated.
Page structure guidance: Pattern pages should be structured for quick scanning by designers. Start with when to use this pattern, then how to implement it. A good structure is:
A concise intro paragraph explaining the pattern in plain language (e.g. “This pattern provides a standard way to ask users for their address, ensuring consistency and ease of use.”).
A “When to use this pattern” section (or similar) detailing situations in which the pattern is applicable, and perhaps when not to use it if there are exceptions. This aligns with GOV.UK patterns, which often have such guidance
design-system.service.gov.uk
.
A “How it works” or “How to design this” section, which can include subheadings for different aspects (like form structure, validation, accessibility tips). Use GOV.UK Style: short headings and short explanatory paragraphs or lists.
If relevant, include visual examples. For instance, an image of the UI or a code snippet – the CMS should allow embedding code or screenshots. Each example should have an accessible description or caption.
Possibly a “Research and evidence” section if the pattern is based on user research findings (some design system patterns include this to explain why the pattern is effective).
Related links at the bottom: e.g. link to any Standards that mandate using the pattern (like a security pattern might link to a security standard), Guidance for more detail, or external references (like the GOV.UK Design System or WCAG guidelines).
Ensure that the page uses consistent design language and that any coded examples are up-to-date (if code is provided, consider linking to a living code source like a GitHub repo or the DfE Frontend library, rather than duplicating code blocks too often).
Interconnections: Patterns intersect with multiple other content types:
Standards → Patterns: A standard may require or recommend using certain patterns. For example, an accessibility standard might mention using an approved pattern for navigation to meet accessibility needs. Therefore, pattern pages should reference which standards they help address (e.g. “This pattern helps you meet [Standard Name]”).
Guidance → Patterns: Guidance pages often suggest using specific patterns. For instance, a content design guidance might link to a “Plain language content pattern” if one exists. In the other direction, pattern pages might link to detailed guidance on content or research relevant to the pattern.
Tools/Components: Patterns often rely on coded components (like the DfE Frontend or GOV.UK Frontend). The pattern page should link to those Tool or Template entries if they are catalogued (for example, if “DfE Frontend library v2.1.0” is a resource in the manual, the pattern can link to it for developers to download or reference). We saw news that DfE Frontend updates are announced
design.education.gov.uk
; a pattern page could reference the toolkit version needed.
Case Studies/Design Histories: If a design history entry demonstrates implementing a particular pattern, consider linking to it as an example (“See how the XYZ team used this pattern in their service”). Conversely, tagging design history posts with the patterns they used can help readers find real-world usage.
Community: Patterns might come from community contribution. The manual might connect pattern pages to the Community or support info section, e.g., “Discuss this pattern in the design community forum” or Slack channel.
Governance notes: Patterns benefit from strong governance because inconsistent patterns can confuse users. Typically, a Design System or Design Authority governs design patterns. For DfE, the DesignOps team or Design System team would review and approve new patterns (the design manual news suggests DesignOps involvement in standards and pattern updates
design.education.gov.uk
). Patterns should be version-controlled especially if they include code – e.g., tie pattern updates to version updates of the DfE Frontend toolkit
design.education.gov.uk
. An approved pattern might have a status of “Experimental”, “Pilot”, or “Official” (fields to capture its maturity). Ownership should be assigned (e.g. “Maintained by DfE Design System team”). Encourage community feedback on patterns – possibly via a feedback link or integration with GitHub for suggestions (as some design systems do). In the CMS, patterns can be updated by authorized designers and reviewed by the pattern owner before publishing. All this ensures patterns remain effective and in line with both DfE needs and wider GOV.UK standards (indeed, Home Office and others contribute patterns back to GOV.UK Design System
design.homeoffice.gov.uk
, so DfE should align patterns to GOV.UK conventions too).
Tool or Template
Definition: Tools or Templates are reusable resources such as software tools, services, documents, or code repositories that help teams deliver services. A tool could be an application or service (for example, the “Service assessment booking service” or an internal prototyping tool), while a template could be a document or file that teams can copy and use (for example, a project brief template, or a design review checklist). Essentially, this content type catalogs the tangible assets that complement guidance and standards. Primary use cases:
Delivery teams use tools to streamline work (e.g. using an accessibility testing tool, or a template for writing a privacy notice).
Community leads or Ops teams list these resources in the manual so everyone is aware of approved tools (avoiding duplication or the wrong tools).
New staff or teams can find official DfE templates (ensuring consistency in documents like Service Design Documents, Business Cases, etc.) and find links to internal systems or software they should use (like where to raise an accessibility issue or how to access a code repository).
For technical users, tools could include code libraries (like the DfE Frontend, API client libraries) and for non-technical users, templates might include policy documents or research consent form templates.
Key fields/attributes:
Title – Name of the tool or template. Keep it straightforward (e.g. “DfE Frontend v2.1.0”, “Accessibility Audit Request Form”).
Slug – URL slug (e.g. “dfe-frontend-2-1-0” or “accessibility-audit-template”).
Type – A classification (tool, template, software, document, etc.). Could be a dropdown or tag.
Description – A short description (one paragraph) explaining what the tool/template is and why to use it. For example: “DfE Frontend is a set of reusable components and styles for services, based on the GOV.UK Design System
design.education.gov.uk
.”
Usage guidance – Instructions or notes on how to use the tool/template. This might include prerequisites or a summary of steps (if brief). For longer instructions, it could link to a Guidance page. For a template, mention what it’s for (e.g. “Use this template to document user research findings; fill in sections X, Y, Z.”).
File or Link – The actual resource:
For a template, this could be a file download (e.g. Word, Excel, Google Doc link). In Strapi, maybe an upload field or URL field.
For a tool, this might be a link to the tool’s site or an entry if internal (e.g. a link to a GitHub repo or an internal web app). Provide context if it requires login or is internal-only.
Version – (if applicable) version number of the tool/template. Important for things like code libraries (so teams know they’re using the latest) or document templates (with version date).
Owner/Maintainer – Who maintains this tool or template (name of team or role). For example, a template might be maintained by the Service Design team, a software tool by the Engineering team.
Related content – Links to any related guidance or standards:
E.g., an “Accessibility Statement Generator” tool would relate to the standard for accessibility statements
accessibility.education.gov.uk
 and any guidance on writing statements.
A “service design document template” might relate to guidance on service documentation or a lifecycle phase like Discovery.
Tags – Tags for quick filtering, e.g. “Accessibility tool”, “Testing”, “Template-Document”, “Code library”.
Last updated – Date when the tool info or template was last updated in the manual (especially if linking to an external version, note if outdated).
Page structure guidance: For a tool/template page, keep it succinct and actionable:
Begin with a summary paragraph that states what the tool/template is for and who should use it. Assume the reader needs to quickly decide if this is what they need.
If it’s a template or document, you might include a preview or screenshot (if helpful and feasible) via an embedded image, so users can visually confirm it. Ensure any images are accessible (with alt text).
Use a bulleted list for key points or requirements, if needed. For instance: “To use this tool, you will need: access to the DfE network and a GitHub account” or “This template includes: sections for background, user needs, and metrics.”
Provide a clear call to action link or button, e.g. “Download template (DOCX)” or “Open tool” prominently, so users don’t have to hunt for it.
If further instructions are needed, either include a brief “How to use” section or link to a detailed Guidance page. For example, if the tool is complex, link to “See guidance on using the [Tool Name]” so the main page stays concise.
Include any support info if relevant: e.g. “If you need access to this tool, contact [email/team]” or “Report issues on [GitHub link]” for open-source tools.
Keep paragraphs short and use plain language (for example, instead of “Utilize this template to formalize requirements,” say “Use this template to write down what your service needs to do”).
Interconnections: Tools and templates often support the implementation of other content:
Guidance ↔ Tools: Guidance pages will frequently mention tools or templates. For instance, a guidance on “Conducting an accessibility audit” will reference the “Accessibility Audit request form” template
accessibility.education.gov.uk
. In the CMS, we ensure those references are hyperlinked. Conversely, the tool page can link back to the guidance (“See How to get an accessibility audit for when to use this form”).
Standards ↔ Tools: Some standards require using specific tools or outputs. E.g., an assurance standard might require an architecture decision record template to be filled out; the standard page can link to that template. The tools can be tagged with related standard codes or names to show relationships (maybe even an automated list of which standards mention them).
Patterns ↔ Tools: Design or code patterns may be delivered through tools. For example, a pattern could mention that the DfE Frontend library provides the necessary components – linking to the DfE Frontend tool page ensures designers/devs can find the code.
Community/Support: It’s useful to link tools/templates with community pages – e.g. a “Community or Support” page might have a list of tools the community maintains. Or a “DesignOps support” page might inventory tools available to designers. The tools content type enables that inventory with rich detail, instead of static lists.
Lifecycle Stage: Some tools/templates are phase-specific (e.g. a “Discovery phase checklist template” or a “Beta readiness assessment form”). Tagging them with the relevant Lifecycle Stage ensures when someone reads about that stage, they see the tools available (perhaps surfaced as related content or via search filters).
Governance notes: Each tool or template should have a clearly assigned owner for maintenance. For templates, the content should be reviewed periodically to ensure they align with current standards (e.g., if policy changes, update the template). For software tools, ensure the manual links to the latest version or location. The CMS can assist by allowing owners to update descriptions and links easily. It might be wise to have a convention: if a tool is deprecated or superseded, mark it clearly (an “Active/Retired” status field) so users aren’t misled. Approval to add new tools/templates should go through a governing body (to avoid listing unofficial tools). Since this is a structured CMS, avoid duplication: instead of uploading a file multiple times for multiple pages, have one Tool/Template entry and link to it from various guidance pages as needed. This way, updates to the tool info happen in one place (helping to reduce duplication across the manuals). Also, maintain compliance with open licensing – if templates are under Open Government Licence, it’s already noted globally, but any exceptions should be noted.
Process
Definition: A Process page defines a set of steps or a workflow that teams in DfE need to follow for governance, assurance, or operational purposes. This can include things like service assessments, audits, approvals, or other lifecycle processes. Essentially, it documents “how to go through” a required procedure in the department. For instance, service assessments are a process where services are evaluated at phase-end against the Service Standard
apply-the-service-standard.education.gov.uk
, and accessibility audits or security assurance steps would also be processes. These pages ensure teams know what to do, when to do it, and what the outcomes are. Primary use cases:
Delivery teams use these pages to understand what formal processes they must engage in (e.g. “What do I need to do to pass a service assessment?”, “How do I get an accessibility audit?”).
Assessors or governance staff use them as a reference for how to conduct the process (e.g. guidance for assessors on running an assessment
apply-the-service-standard.education.gov.uk
).
They help project managers and product owners plan for required gates (knowing what criteria must be met and what documentation to prepare).
Provide transparency on DfE’s internal governance so that teams can self-serve information instead of relying on email chains.
Key fields/attributes:
Title – Name of the process, stated in plain language. For example, “Service assessments”, “Accessibility audit process”, “Design review process”.
Slug – URL slug (e.g. “service-assessments”, “get-accessibility-audit”).
Summary – A short intro that explains what the process is and why it exists. For example: “Service assessments are compulsory evaluations at the end of each phase to ensure your service meets the Service Standard
apply-the-service-standard.education.gov.uk
.”
Audience – (Optional) A field to indicate who the page is for, if needed. For example, some process pages might be split into “For teams” vs “For assessors”
apply-the-service-standard.education.gov.uk
. This could be a tag or a section indicator.
Prerequisites/Conditions – A section or list of conditions for the process (e.g. “You must complete a discovery peer review before requesting an alpha assessment”
apply-the-service-standard.education.gov.uk
). Could be structured as a bullet list of what needs to be in place.
Steps or Stages – The core content detailing the process. Ideally structured as:
Step-by-step list: Use numbered headings or a numbered list for each major step. For example, Step 1: Do X; Step 2: Panel does Y; Step 3: Outcome Z.
Each step can have a short description. If steps branch by scenario (like DfE panel vs cross-government panel in assessments), consider sub-sections under the relevant step
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
.
Roles involved: Within steps, highlight who is responsible (e.g. “the team should…”, “the assessor will…”).
Timeline/When – (If not obvious from steps) clarify at what project phase or timing the process happens. For example, note that assessments occur at end of alpha/beta
apply-the-service-standard.education.gov.uk
, or that an audit should be requested 4 weeks before a deadline, etc.
Outputs/Deliverables – What the result of the process is. E.g., “a report will be produced with recommendations”
apply-the-service-standard.education.gov.uk
 or “you will receive approval to proceed to beta if successful”. This can be a short section summarizing outcomes.
Related tools – Link to any systems or forms used in the process. For instance, if booking is done via a service (like the “Service assessment booking service”
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
, include a prominent link or button to that tool). Another example: an “accessibility issue tracker” link if the process is managing issues.
Related guidance or templates – Many processes have guidance pages or templates attached. E.g., a “service assessment report template” might be linked for assessors, or a “checklist” guidance to prepare for the assessment. These should be listed or linked either inline or at the end.
Contact/Support – Contact info for who to reach out to with questions about the process (e.g. “Email the Service Assessment Plus team for any questions”
apply-the-service-standard.education.gov.uk
).
Governance info – (Optional) Who oversees the process (a particular team or committee), if that’s useful to note.
Page structure guidance: Process pages often cover a lot, so clarity is vital:
Start with an overview section (could be unlabelled or titled “Overview”) that explains what the process is and why it matters
apply-the-service-standard.education.gov.uk
. Keep this concise and use plain language (avoid jargon like “Stage-Gate” – instead say “must be assessed at end of each phase”).
If the process differs by audience (teams vs assessors, etc.), consider using tabs or clearly separated subheadings. The example from DfE shows separate links “For teams” and “For assessors” leading to tailored guidance
apply-the-service-standard.education.gov.uk
. In a single page, you could achieve this with H2 headings “For teams” and “For assessors” if combining, or maintain separate pages with cross-links.
Use numbered lists or headings for sequential steps. If the process is linear, an ordered list (1, 2, 3) is good. If it’s more complex, break into sub-sections with headings per stage (e.g. “## DfE panel assessment” and “## Cross-government assessment” as in the service assessments page
apply-the-service-standard.education.gov.uk
apply-the-service-standard.education.gov.uk
).
Each step description should be short, ideally no more than a few sentences or a couple of bullets, focusing on the action and responsible party. For example: “Book a DfE panel assessment using the Service Assessment booking service
apply-the-service-standard.education.gov.uk
.” If a step requires explanation, use sub-bullets or an indented paragraph under that step.
Highlight important criteria or definitions. The service assessment page, for instance, defines what counts as a “transactional service” in a bullet list
apply-the-service-standard.education.gov.uk
 – doing this helps readers understand the context without needing external references.
Include callouts for key differences or tips. For example, if some projects might be exempt or if there’s a tip to prepare (like “Tip: do a mid-phase peer review to get feedback early” which is mentioned as optional
apply-the-service-standard.education.gov.uk
).
End with a support/contacts section (could just be a sentence or two) telling users where to get help or more info
apply-the-service-standard.education.gov.uk
. Also, keep the feedback component at the bottom (as standard).
Throughout, adhere to GOV.UK style: short sentences, “you” for the service team, active voice. E.g. “You need a cross-government panel if…
apply-the-service-standard.education.gov.uk
” instead of passive language.
Interconnections: Process content ties together many aspects of the manual:
Lifecycle Stage ↔ Process: Many processes occur at specific lifecycle stages. For example, service assessments at end of Alpha/Beta (so likely referenced on the Lifecycle Stage pages for Alpha and Beta). The “Discovery peer review” is clearly tied to the Discovery stage
apply-the-service-standard.education.gov.uk
. We should ensure each process page is tagged or referenced by the relevant stage page, so a team looking at “Discovery phase” sees that a peer review process exists. Conversely, within the process page, mention the stage (like “in discovery phase, you should do X”).
Tools ↔ Process: As noted, processes often have tools. The content model should allow linking directly to booking forms, issue trackers, etc. For example, the process page directly links to the Service assessment booking service
apply-the-service-standard.education.gov.uk
. In the unified manual, this might be an embedded link or even an embedded application if possible. Similarly, for accessibility issues, it references the Accessibility Statement service.
Roles ↔ Process: Process pages often involve specific roles (like “assessor”, “product manager”, “accessibility lead”). We might link those role pages for clarity (e.g. “Accessibility assessor role” page is linked from accessibility standards
accessibility.education.gov.uk
). In a service assessment process, mention of “Service Assessment Plus team” could link to a community or role page describing that team.
Standards/Guidance ↔ Process: Processes ensure standards are met (e.g. the assessment ensures teams are meeting Service Standard
apply-the-service-standard.education.gov.uk
). So, process pages might reference standards (“... working towards the Service Standard
apply-the-service-standard.education.gov.uk
”). Also, guidance pages can exist to help with each process step (e.g., a guide “How to prepare for a service assessment” would complement the process page). Cross-link these so users can easily navigate between what they need to do (process) and how to do it (guidance).
News/Updates: If processes change, News or Announcement items likely communicate that (“New service assessment criteria in effect...”). Having the process content type structured with versioning or clear owners means any significant change should be clearly indicated (perhaps with an “updated on [date]” note). News posts can link to the updated process page.
Governance notes: Process documentation should be maintained by the process owners (e.g., Service Assessment Plus team for assessments, Accessibility team for audits). It’s crucial these pages are kept up-to-date because teams rely on them for compliance. Set a review schedule – e.g. any time policy changes (like GDS updates assessment guidance) or at least quarterly. The content type lends itself to versioning if needed (though often just updating is fine). If the process has a policy basis (Cabinet Office mandate, etc.), consider linking out to the authoritative policy for transparency. In terms of approvals: changes to a process likely require sign-off from the governing group (for example, changing service assessment criteria might need approval by a departmental digital board). This implies an editorial workflow in the CMS for process pages. Each process page should list a contact or owner team for governance (we saw an example: “contact Service Assessment Plus team”
apply-the-service-standard.education.gov.uk
). This person/team can also handle feedback that comes in (e.g., via the page feedback form or direct emails). By structuring processes clearly, the manual also helps reduce duplication: previously, each community might have documented processes separately; now one authoritative page can be linked from multiple places (e.g., both the technical and design sections can link to the same “service assessment” process page rather than describing it separately).
Case Study / Design History
Definition: A Case Study or Design History page is a narrative content type that captures examples of how teams have built or improved services, including what was done, why, and what was learned. In DfE’s context, Design History refers to working in the open to show how services change over time
design-histories.education.gov.uk
. These pages document real project experiences – they can be post-mortems, design decision logs, user research findings in context, or general “story of how we did X”. They serve as both a historical record and a learning resource for others. Primary use cases:
Team members across DfE read case studies to learn from others’ experiences (e.g., how another team solved a common problem, or approached a new design challenge). This spreads good practice and prevents repeating mistakes.
Designers and researchers use design histories to see the evolution of service designs, which is valuable for design reviews or onboarding new designers to a project.
Stakeholders or new teams might use these to get inspiration or to justify certain approaches by citing existing successes.
The act of writing design history posts also encourages teams to reflect and document their rationale (improving institutional knowledge).
Key fields/attributes:
Title – A descriptive title that often includes the key insight or change, possibly with a project context. For example, “Improving consistency across the service” with a subheading for the product name
design-histories.education.gov.uk
, or “Using information boxes effectively in [service name]”
design-histories.education.gov.uk
. Some teams include the project name in the title or as a separate field.
Subtitle/Project name – It’s useful to capture the product or team the case study is about. In design histories, we see a line showing the service or team name, e.g. “Teaching record system (TRS) console” below the title
design-histories.education.gov.uk
. This could be a dedicated field (Project/Service) that is displayed prominently.
Date – Publication date of the post
design-histories.education.gov.uk
. This indicates when the case study was written (which often correlates to the phase of work).
Author(s) – Who wrote it (could be one or multiple team members, often including their role). Including authors is optional but can give context and a point of contact. If multiple authors or a team wrote it, listing the team name is fine. In some DfE design history entries, the team name stands in place of an explicit author.
Tags/Topics – Tags for themes or topics covered. The design history service shows a “Posts by tag” cloud
design-histories.education.gov.uk
 (accessibility, data, content design, etc.), meaning each post likely has multiple tags. Tags might include the type of issue (e.g. “Accessibility”, “Data”), the type of method (like “User research”), or domain (like “Schools”). These help in filtering and discovering relevant case studies.
Body content – The narrative content, which may include:
Background: context of the service or problem. Often a case study starts with what the service is and what needed improvement.
What we did: description of actions taken or designs tried. This can include images (screenshots of designs, diagrams), bullet points of steps, or quotes from users/research.
Challenges: any issues or considerations faced.
Outcome/Results: what changed as a result, any metrics or user feedback improvements, lessons learned.
The tone is usually first-person plural (we did this) and past tense, as it’s reflective.
Images or media – Case studies benefit from visuals. There should be ability to embed images within the narrative (with captions). E.g., a screenshot of an old vs new design, or a graph of usage.
Related content links – Possibly a list of related case studies or guidance. For example, if a case study references a pattern or guidance, link to it (“we followed the [XYZ pattern]”). At the end, could have “See also: [Another case study on similar topic]”.
Status/Phase – (Optional meta) Indicate the project phase (Discovery, Alpha, Beta, Live) during which this story took place, if relevant. The project name field plus date often suffice to infer this, but an explicit tag could help (e.g. a tag “Alpha phase” or similar).
Team or Programme – If not captured via project name, a field for the team (like “Support for social workers team”) which might be a reference to an entry in “Community or support info” (if teams are listed there) or just free text.
Page structure guidance: Case studies/design history entries are typically formatted as blog posts:
Use a consistent layout: title at top, followed by meta info (project name, date, author). For instance, on the design histories site, the listing shows “Title – summary – project name – date”
design-histories.education.gov.uk
. On the detail page, likely it starts with title then content. We should ensure the project/service name is visible near the top so readers immediately know the context (maybe as a subheading or in metadata).
The introduction (first paragraph or two) should set the scene. It might be in bold or just normal text, but it should summarize the problem or what the post is about (like a standfirst).
Break up the narrative with headings that reflect the flow (e.g. “Challenge we faced”, “Our approach”, “What we learned”). This helps scanning. However, since these are stories, headings might be more free-form. Encourage teams to still use them for structure.
Use images and diagrams to illustrate changes. Captions should explain what the image shows. For example, if showing a before-and-after of a screen, caption it “Old design (left) and new design (right) for the X page” or similar.
Write in a human, conversational tone but still concise. GOV.UK style is user-focused; for design histories, it’s acceptable to use “we” and “our users” etc. Keep paragraphs short to improve readability.
Possibly include quotes or user feedback callouts if relevant (like an aside style for “One user said: ‘…’”). This adds authenticity.
End with a result or next steps section. Many case studies conclude with results or how it influenced the next phase. If applicable, mention if the service passed a Service Assessment or what will happen next (e.g. moving from Private Beta to Public Beta).
Optionally, have an attribution or thanks line if multiple team members contributed.
Allow commenting or encourage discussion in the community? Not likely in the manual directly, but ensure contact can be made (maybe through the author or a Slack channel link in the Community section).
Interconnections: Case studies connect knowledge to practice:
Tagging to themes: Because case studies are tagged with topics (like “Accessibility”, “Data”, “Content design” etc. in the design history site
design-histories.education.gov.uk
), users can find all stories relevant to a particular theme. In our unified manual, these same tags could be used across content types or specifically for case studies. It might be beneficial to keep a separate taxonomy for case study topics vs formal categories, depending on CMS capability. But cross-linking by tag is powerful (e.g. clicking “Accessibility” tag shows all case studies on accessibility).
Links to standards/guidance: If a case study narrates how a team met a standard or used guidance, those references should hyperlink to the relevant manual pages. This not only enriches the story but also validates the guidance (“we followed the GOV.UK Design System pattern
design-system.service.gov.uk
 for this”). Conversely, guidance pages might link out to case studies as real examples (“See how the TRS team implemented this guidance in practice”).
Lifecycle Stage: Each design history post naturally falls under a stage (Discovery research summaries, Alpha experiments, Beta improvements, Live iterations). The manual might allow filtering case studies by stage, or the Lifecycle Stage pages can list exemplar case studies for that phase. For instance, on the “Discovery” stage page, link to a couple of Discovery phase case studies.
Community or Team pages: If we have pages for each Team or Community, those pages could list the case studies that team has published (like an archive of that team’s design history). The design histories site has a “Teams” section
design-histories.education.gov.uk
 which probably groups posts by team. So, in the unified model, a Team page (or Community page) can dynamically display “Recent posts by this team.”
News vs Case study: Sometimes an item might be newsy and a case study. Generally, if it’s narrative and instructional, it belongs as a case study. News is more announcement style. However, a news article might announce a publication of a case study or link to it. Keep them distinct but cross-reference if needed.
Governance notes: Writing case studies should be encouraged but also lightly governed to maintain quality and avoid accidental disclosure of sensitive info:
Typically, each team is responsible for their design history entries (“working in the open” culture). The manual should provide guidelines (maybe a Guidance page on “How to write a design history post”) aligned with content design principles. For example, avoid jargon, do not include any personal data of users, ensure images are redacted of any sensitive info, etc.
Possibly designate a community manager or editorial team (like the DesignOps team) to review case study content before it goes live, mainly for adherence to style and confidentiality checks, not to stifle the authentic voice.
No formal approval from on high should be needed for honest case studies (or it defeats the openness purpose), but having a second pair of eyes is wise.
Use an open licence for content (the site already says OGL applies
design-histories.education.gov.uk
). If a case study includes something not under OGL (like a user quote under specific consent), clarify that as needed.
Encourage consistency: for example, always include the project name and date. Perhaps provide a template or content type form that ensures authors fill those in.
Over time, maintain an index or allow search to cover case studies, since a large ecosystem could have many. The CMS can provide listing by date, by tag, by team. Ensure these pages (like “Recent posts”
design-histories.education.gov.uk
 and “Older posts”) are automatically updated via the content model (as opposed to manually curated).
Archiving: If a project ends or a case study becomes outdated, generally it’s still valuable historically, so we’d keep them. But if any need retraction (rare), have a process for that.
Role / Profession
Definition: A Role or Profession page describes the people side of the service delivery ecosystem – either an individual role (like “Content Designer”, “Delivery Manager”) or a profession community overview (like “User Research profession in DfE”). These pages define what the role entails, how it fits in service teams, and resources for that role. Essentially, they answer “Who does what, and what does that mean?” for digital roles in DfE. In a unified manual, this helps clarify responsibilities and builds a shared understanding among multidisciplinary teams. Primary use cases:
Team members and hiring managers use role descriptions to understand what competencies or responsibilities a role should have (especially useful if someone is new or defining team roles).
People in those roles find tailored resources – often a profession page will link to guidance, standards, and communities relevant to their role (for example, a User Researcher finds links to user research guidance, tools, and the community of practice).
Communities of practice leaders use profession pages to communicate frameworks (like capability frameworks, career pathways) and to unify the practice across the department.
Job applicants or HR might also refer to these to align job descriptions (since DfE apparently has a “Find a job description” site
design.education.gov.uk
design.education.gov.uk
, the content model can tie into that).
Key fields/attributes:
Title – The name of the role or profession. E.g. “Content Designer”, “Service Owner”, or broader like “Design Profession”. For an overview page, it could be “The Design Profession in DfE”.
Role type – A field to distinguish if this entry is an individual role vs a profession overview vs a capability framework. Perhaps a category or toggle.
Summary – A one-liner describing the role/profession in plain English. For example, “Content designers make sure users get the information they need in a clear and accessible way.”
Responsibilities/Duties – A list or section outlining what the role does in the context of service teams. Bullet points work well for responsibilities. For consistency with GOV.UK style, use verbs at the start of each (e.g. “Research user needs and evaluate service usability” for a user researcher).
Key skills/competencies – Especially if referencing a skills framework, list the core competencies required or expected for the role. This might be summarized from a capability framework
design.education.gov.uk
. Could be a simple list or a link to the detailed framework.
Relevant standards/guidance – A curated list of content in the manual most pertinent to someone in this role. For example, on a Content Designer role page, list “Content Design guidance, Plain Language standard
standards.education.gov.uk
, Accessibility guidance” etc., each linking to those pages. This effectively serves as a quick reference library for that role.
Community/Support – Information on the community of practice or support mechanisms for the role. E.g., “Join the #content Slack channel” or “Our Head of Profession is [Name] – they set standards and support content designers.” Could also link to any “Community” page (see next section) or external groups. In DfE design manual, they have a DesignOps and roadmap sections to support the profession
design.education.gov.uk
.
Career progression/Grades – If applicable, outline how the role progresses in the civil service grade structure (perhaps linking to the skills framework or “find a job description” for each level). For instance, mention junior vs senior expectations, or link to specific job description templates on the job description site.
Examples/Case studies – Optionally, link to any case studies featuring someone in that role (“A day in the life of a Delivery Manager on Project X”) if available, or design histories written by people in that role as examples of their work.
Additional resources – Links to external guidance like the GDS role descriptions or Government Capability Framework for the profession, or training materials.
Page structure guidance:
If this is a role page, start with a clear definition: “What is a [Role]?” as a short paragraph. E.g., “User researchers help service teams learn about their users and their needs to design better services.”
Then, possibly have a “What they do” section (or just a bold lead-in line) followed by bullet points of main responsibilities.
A “Skills needed” or “Competencies” section can list key skills. This can be drawn from the DfE or DDaT capability framework, but written in plain language (not just HR jargon). For readability, bullets or a table of competency categories might be used.
If the content is more of a profession overview (like “Design Profession”), you might structure it as:
Overview of the profession in DfE (how many people, what roles it includes, etc).
Links to the roles under it or skill framework.
Info on the community and governance of that profession (e.g. Head of Design Profession, community meet-ups).
Headings: use them to break out logical areas: “Responsibilities”, “Skills and knowledge”, “Tools and standards for [Role]”, “Community and support”.
Use a consistent tone speaking about the role, but you can also address the practitioner: e.g. “As a content designer, you should follow the DfE style guide
standards.education.gov.uk
 and collaborate with user researchers and designers.”
Keep paragraphs short and use simple terms. Avoid internal job grade codes in the user-facing text (you can mention levels as “junior”, “senior” rather than HEO/SEO, unless targeting an internal audience).
Incorporate GOV.UK style: for example, not capitalizing job titles unless referring to a specific person’s title. Use “you” if giving advice to someone in the role (“If you are new to this role, see the design skills framework for expectations at different levels.”).
If relevant, include a snippet or callout quote from someone in that role (“‘Content design isn’t just writing, it’s designing how content interacts with users’ – Jane, Senior Content Designer”). This can add a human touch.
Interconnections: Role/Profession content is a hub that connects people, content, and support:
Guidance/Standards ↔ Role: As noted, role pages should list or link to the key standards and guidance that role uses. Conversely, some guidance pages or standards might indicate which roles are primarily responsible. For example, a standard about user research ethics might note “This standard is owned by the User Research profession” or “User Researchers and Data Protection Officers should be aware of this” – linking the term “User Researchers” to the role page.
Community ↔ Profession: Likely, a Community or Support page exists for each profession (the next section). The role page can link to it (like “See the User Research community page for how to get involved and support available”). In DfE’s manuals, for example, the Architecture site had separate pages for “Architecture roles”, “Architecture profession”, and “Architecture community”
dfe-digital.github.io
. In a unified model, we might consolidate or clearly cross-link those.
Case Studies: As mentioned, link to stories involving that role. Alternatively, tag case studies by roles involved so that a content designer could filter case studies where content design had impact. This is advanced but useful (not all CMS easily do that, but tags could approximate it).
Job Descriptions: If DfE maintains a database of job description templates (as hinted by job-descriptions.education.gov.uk
design.education.gov.uk
), link out to those for detailed specifics like pay grades, etc. The manual’s role page is more about practice and community; the HR site is formal JD. Ensure not to duplicate that content, just reference it.
Lifecycle ↔ Roles: Lifecycle stage pages might mention which roles are typically active during that stage (e.g. Discovery mainly involves user researchers, service designers, etc.). Those mentions can link to the role pages, giving readers context on who does what in each phase.
Principles ↔ Profession: Some professions have principles (e.g. design principles, research principles). If so, link the principle pages. For instance, a “Design Principles” page (if defined under Principles content type) is relevant to all designers – the design profession page should highlight those principles
dfe-digital.github.io
dfe-digital.github.io
 (architecture site example shows principles by area).
Governance notes: Content about roles and professions should be overseen by the Head of Profession or community leads for accuracy:
For each profession, the Head of Profession (or equivalent) should sign off the description and maintain the content (since these can align with DDaT framework or departmental structures). For example, the Head of Design or Head of User Research in DfE likely provides input to those pages.
These pages should reflect current practice and expectations, so they might be updated when, say, the capability framework updates or if DfE’s approach to a role changes. (E.g., introducing a new role like “Service Mapper” would mean adding a page or updating a profession overview.)
Versioning is less critical here, but having a last updated note helps.
Avoid duplicating entire frameworks; link to official docs when necessary (for detail), while keeping the manual focused on day-to-day understanding.
Since roles pages are partly informational and partly directional, ensure consistency (maybe have a small group of content designers craft all role pages using a similar template).
Inclusion: ensure the language encourages diversity and doesn’t inadvertently set unwritten requirements. It should focus on what the role does, not who they are (no gendered language, etc.).
If the manual is public, double-check that nothing sensitive (like internal-only details) is exposed. Usually role descriptions are fine to be public as they often mirror GDS role descriptions.
Principle
Definition: Principles in the Service Manual are high-level truths or value statements that guide decision-making and design. They are the “north star” statements for various disciplines – for example, design principles, accessibility principles, architecture principles, or general service design principles. They are enduring and must be considered whenever creating or improving services. Unlike standards (which are specific requirements) or guidance (practical advice), principles are more abstract but help ensure consistency in approach and ethos (e.g. “Accessible design is good design”
dfe-digital.github.io
). Primary use cases:
All team members refer to principles to align their work with DfE’s and GOV.UK’s core values (for instance, knowing the DfE design principles ensures a designer’s decisions align with departmental expectations).
Leadership and reviewers use principles as a lens to evaluate solutions (“Are we following the principle of starting with user needs?”).
Onboarding: new staff learn the guiding principles early to understand the culture of delivery.
They can be used in presentations or proposals to justify decisions (“We did X because ‘if it’s not accessible, it’s not done’ – one of our principles
dfe-digital.github.io
.”).
Key fields/attributes:
Title – Often the principle set name or a concise principle statement. There are two levels: sometimes an entry is a collection (like “Design Principles”) and within it individual principles (like a list of numbered principles). The CMS should handle both:
For a collection page: Title might be “DfE Design Principles” or “Accessibility Principles”.
For individual principles (if each is a separate entry): Title would be the principle phrase, e.g. “Inclusion is better than empathy”
dfe-digital.github.io
.
Description/summary – If it’s a collection page, a short intro of what these principles are and origin (e.g. “These principles encapsulate how we approach accessibility in design, originally adapted from DWP’s principles
dfe-digital.github.io
.”). If it’s an individual principle entry, this might be the tagline or brief explanation.
List of principles – If using a single page for a set, then the body would list each principle, typically numbered, with a heading and explanation for each
dfe-digital.github.io
. If each principle is an entry, then perhaps group them via a Principle Set field.
Body content (for each principle) – Typically, each principle has:
A short principle statement (possibly used as the title or subhead).
A description explaining what it means in practice. E.g. “It’s good to understand others’ needs, but don’t assume – include a diverse group...
dfe-digital.github.io
”.
Optionally, examples or implications – sometimes principles pages include bullet examples or what good looks like vs bad (though often left as just statements with explanation).
Applicability – Some principles might be tagged to certain domains. For example, architecture principles might tag “Architecture”. But often principles stand on their own set, so this may not be needed beyond grouping them by discipline.
Related guidance or standards – If there are guidance pages that elaborate on a principle, link them. E.g., a “User-centred design principle” might link to the Service Standard or guidance on user research.
Origin or references – If these principles come from somewhere (like GDS, or cross-gov), it might be good to note that or link out. For instance, link to GDS Design Principles or mention source for credibility. In the accessibility principles example, they credit DWP Digital folks and a SharePoint for more detailed guidelines
dfe-digital.github.io
.
Owner/Steward – Not always displayed, but a metadata of who curates them (e.g. Head of Profession for that area).
Version or date – If principles were established on a certain date or updated.
Page structure guidance:
If one page contains multiple principles (likely for a small set like 5-10 principles):
Start with an intro that might state the purpose of the principles or context (for example, architecture principles page says “This site documents the principles… It complements the UK Government Service Manual…”
dfe-digital.github.io
).
Then list principles as maybe an ordered or unordered list of headings. Often numbered for easy reference (“1. [Principle statement]” as a heading, followed by a paragraph or two explanation).
Ensure each principle heading is descriptive enough to stand alone (some teams use short pithy phrases). Use heading levels consistently (e.g. H2 for each principle if the page title is H1).
Keep explanations concise; if more detail is needed, consider linking to guidance or leaving detail to training materials.
Possibly visually distinguish the principle statement (bold or italic lead-in).
The page could have a table of contents at top if there are many principles, as seen in architecture principles nav
dfe-digital.github.io
.
If each principle is separate (less common unless there are very detailed principles):
Have a main page listing them (with links) and each principle page with the explanation. However, likely easier to manage as one page per set, given these are short.
Follow GOV.UK style: even though principles can sound slogan-like, make sure their descriptions are plain English. For example, explain jargon if used (like “design is not done until accessible” is clear, but if a principle said "Use common standards", you'd explain what standards).
Example structure snippet (based on accessibility principles
dfe-digital.github.io
dfe-digital.github.io
):
1. Inclusion is better than empathy – It’s good to understand how other people might feel, but don’t assume you know their needs... Include a diverse group when designing services.
2. Accessible design is good design – Good design meets needs and solves problems. If you design something inaccessible, you create barriers... It must work for everyone.
(and so on).
If relevant, at end of principles page, provide any links to further info or team contacts. E.g., “For more information, talk to the accessibility team or see guidance on the Accessibility Hub”
dfe-digital.github.io
.
Interconnections:
Standards & Guidance: Principles often underlie standards. For instance, a principle “If it’s not accessible, it’s not done” underpins many accessibility standards
dfe-digital.github.io
. Standards pages could reference principles to reinforce why the standard exists. Conversely, principle pages might link to concrete standards (“This principle is reflected in DfE’s Accessibility Conformance standard
accessibility.education.gov.uk
.”).
Community/Profession: Principles are usually maintained by a profession community (e.g., architecture principles by architects). The architecture community page can link to the principles. Also, role/profession pages might mention “We follow these principles” with a link. For example, the design profession overview might link to design principles (including possibly the GOV.UK Design Principles if adopted).
Lifecycle: Some principles are phase-specific (though usually principles are general). But for instance, if DfE had “Agile principles” or “Discovery principles”, those could tie into phases. The agile delivery section of GDS lists principles for agile governance
gov.uk
, which could be referenced.
Case Studies: Case studies could illustrate principles in action. A design history might mention “we kept in mind the principle that ‘Start with what works’ and reused an existing pattern” – linking that phrase to the principle definition. This makes the principle more than just a poster on the wall; it’s living in practice.
News/Training: If new principles are introduced or updated, that’s a news item (“We’ve updated our Architecture Principles to include sustainability.”). The principles content type, being structured, allows highlighting those changes clearly.
Governance notes: Principles should be relatively stable, but they must be endorsed at a high level:
Typically set by Heads of Profession or strategy leads, possibly with input from GDS if aligning with government-wide principles. For example, DfE might adopt the original GDS Design Principles, or have its own like architecture principles as we saw
dfe-digital.github.io
.
Ensure any new principle goes through discussion in the community of practice and approval by the relevant governance body (like a Design Council or Architecture Board). Once approved, the manual is updated.
Keep a record of changes (though changes to principles will be rare; adding new ones or tweaking wording might happen as the organization matures).
For communication, when principles are first published or changed, accompany with an announcement (internally via email or via the News section of the manual).
The manual content should attribute sources if borrowed (like DWP in the accessibility example
dfe-digital.github.io
), maintaining transparency.
Because principles are somewhat abstract, there is a risk of being overlooked; governance should encourage teams to reference them. Possibly integrate principles into training and onboarding materials (which the manual might link to under Community or Training sections).
No sensitive info likely in principles, so they can be public. Ensure phrasing doesn’t conflict with any official policy.
Lifecycle Stage
Definition: Lifecycle Stage pages describe the phases of service development (for example, Discovery, Alpha, Beta, Live, Retirement) and possibly other key stages in DfE project workflows (like “Pre-discovery” or “Continuous Improvement”). Each page outlines the purpose, key activities, and exit criteria of that stage, aligned with the Government Service Manual’s definitions of agile phases
gov.uk
. These pages help teams understand what is expected at each stage and how to transition to the next. Primary use cases:
Service teams use these pages to orient themselves on what they should be doing at their current stage and to prepare for phase-end assessments or approvals. For example, a team in Discovery can check what they need to achieve before moving to Alpha.
Governance bodies (like spend control or service assessment panels) can point teams to these pages for official definitions of done for each stage.
New team members or contractors unfamiliar with GDS phases can quickly learn DfE’s interpretation of those phases.
They also serve as a hub to link to stage-specific guidance, tools, and standards (since certain activities cluster in certain stages).
Key fields/attributes:
Title – Name of the stage (e.g. “Discovery”, “Alpha”, “Beta”, “Live”, “Retirement”). If DfE has additional internal stages or renamed phases, use those (but likely stick to common terms).
Stage order – A number or ordering field (1 for Discovery, 2 for Alpha, etc.) so that it can be sorted or presented in sequence in navigation or overviews.
Summary – A brief statement of the stage’s goal. For example: “Discovery – understand the user needs and the problem space before you start building”
youtube.com
.
Objectives/Purpose – A section listing what this stage is for. This can be bullet points or a short paragraph. E.g., for Discovery: “Identify user needs, explore the problem, and decide whether to proceed”
youtube.com
.
Key activities – What typically happens in this stage. Bullet list or short sub-sections:
e.g., Discovery activities: user research, mapping existing services, exploring solutions, etc.
Alpha: prototyping, testing hypotheses, etc.
Beta: building a working service, scaling infrastructure, etc.
Live: continuous improvement, monitoring, support.
Retirement: data archiving, redirecting users, shutting down old system.
Entry and exit criteria – Possibly a checklist of what should be in place to start this stage and what must be done to complete it. The exit criteria often tie to service assessment points or deliverables (e.g., “Alpha exit: you have a working prototype and evidence that your solution meets user needs, ready to seek Beta assessment”).
Related standards/gates – Note any formal requirements in that stage:
For example, “Must have a Discovery peer review at end of Discovery”
apply-the-service-standard.education.gov.uk
, “Must pass a Service Assessment at end of Beta”
apply-the-service-standard.education.gov.uk
. Link those process pages.
Or “If spending >£X, must go through spend controls” in certain stages – link to relevant guidance or external requirements.
Recommended roles – Which roles are typically involved or needed in this stage (and perhaps at what capacity). E.g., Discovery emphasizes user researchers and service designers; Beta might require adding developers and DevOps. This could be a simple list of roles or a sentence (“Key roles: user researcher, content designer, service designer in Discovery; add tech lead by Alpha…”). These should align with DfE team guidance.
Deliverables/Artifacts – Common outputs of the stage. For instance, Discovery deliverables might include “discovery report, initial backlog, user personas”; Alpha deliverables: “prototypes, alpha report, architecture proof of concept”; etc. Could list these so teams ensure they have them.
Related guidance and tools – A curated list of manual pages most relevant to that stage. For example:
Discovery page might link to “How to do user research in discovery”, “Discovery peer review process”
apply-the-service-standard.education.gov.uk
, templates for discovery findings.
Alpha page might link to “Prototyping guidance”, “Technology stack guidance” (for trying tech in alpha).
Beta page to “Performance monitoring tools”, “Service assessment prep guidance”.
These can be fields linking to other content entries or just a list of links in content.
Examples/Case studies – Perhaps highlight a couple of case studies from that stage (“See how [Project] approached Discovery”). Could be a dynamic list of tagged case studies or manually selected links for illustration.
Page structure guidance:
Likely present these as guide pages with a consistent format:
Start with a definition sentence: e.g. “Discovery is the first phase of developing a service. In discovery, you investigate the problem and identify users and their needs
youtube.com
.” This aligns with GOV.UK Service Manual language.
A “What you should do” or “Activities in this stage” section: could be bullet points or short paragraphs describing the key activities.
A “Outcomes/exit criteria” section: possibly a checklist of what you should have by the end. Preface it like “By the end of Discovery, you should have:” and list items.
Mention mandatory checkpoints if any: e.g. “End-of-Discovery peer review required” – make this a callout or bold text to grab attention, with link to process.
Use subheadings if needed to break up aspects (like “Team composition” to mention roles, “Outputs”, “Moving to next stage”).
Keep it concise – these are overviews. You can rely on linked guidance for details (like how to do user research is separate; here just say “Do user research – talk to users to gather needs”).
Possibly include a visual timeline graphic of phases (if design capacity allows) for context, but that might be beyond Markdown scope unless as an embedded image.
For Retirement (often forgotten), clearly outline archiving and transitioning responsibilities.
Use future or present tense appropriately (“During alpha, you build prototypes and test different solutions.”). Directly address the team (“you”) to keep it actionable.
At the bottom, include links to next/previous stages for easy navigation (Discovery page links to Alpha page, etc., creating a step-through effect). Also link to related content like Service Standard or high-level guidance from GDS if needed (like the GOV.UK Service Manual page on phases, for additional detail).
Interconnections:
Process ↔ Lifecycle: As mentioned, highlight processes that occur at each stage. For example, the Discovery stage page will say “At the end of Discovery, you will have a Discovery Peer Review
apply-the-service-standard.education.gov.uk
 (link) instead of a full assessment”. Alpha/Beta pages will mention service assessments
apply-the-service-standard.education.gov.uk
. Live might mention periodic assessments or health checks. This ensures teams know about these governance steps at the right time.
Guidance ↔ Lifecycle: Many guidance pages are stage-specific. Tag or associate them. E.g., all “Discovery” methods guidance (user research, problem mapping) can be tagged with Discovery. The stage page can then auto-list those via a query or manually link key ones: “Guidance for Discovery: How to do user research, Service Mapping, etc.” Similarly for Alpha (prototyping, tech spike guidance), Beta (accessibility & performance testing, going live checklist), Live (operational monitoring, incident management guidance).
Roles ↔ Lifecycle: As suggested, mention roles. Possibly link each role to its description. Conversely, role pages might talk about their involvement per phase (“A Content Designer in Discovery focuses on exploratory content needs; in Beta, on refining content with user feedback.”). This cross-info can help, but at minimum, stage pages list roles needed.
Standards ↔ Lifecycle: Some standards apply strongly at certain stages. For example, certain technical standards must be addressed by Beta (like security penetration testing standard may kick in by Beta). If there’s any chronological aspect, mention it: e.g. “Ensure by Beta you meet all applicable security standards (see Standards list)” – linking to or listing key categories. Also, the Service Standard itself is basically stage-gated (must fully meet by Live), so the Beta page might emphasize preparing to meet all points of the Service Standard. Perhaps link to “Apply the Service Standard in DfE” guidance
apply-the-service-standard.education.gov.uk
 which enumerates those points with DfE specifics.
Case Studies ↔ Lifecycle: Great to provide context – e.g., embed or link a “Discovery phase example: [Project X discovery findings] (case study)”. People often seek examples to know what good looks like. Could have one or two highlighted for each stage.
Community ↔ Lifecycle: Communities of practice often rally around specific stage challenges (like a “Discovery community of practice” or cross-government events). Possibly mention if there's a support network: e.g., “If you need help in discovery, join our #discovery Slack channel or contact the Service Design community”.
Governance notes: Lifecycle definitions likely follow GDS guidance but may have DfE-specific nuances:
Ensure they are aligned with GOV.UK Service Manual so external requirements (like GDS Service Assessments, spend controls) are accurately represented. The architecture site explicitly says it complements the UK Government Service Manual
dfe-digital.github.io
 – implying the unified manual shouldn’t contradict central guidance, just tailor it.
These pages might be stewarded by a central Digital Delivery or Service Excellence team in DfE to keep consistency. Likely the Service Assessment Plus team or similar should review as they enforce these stages.
If policies change (like introduction of a new stage or change in spend control thresholds), update promptly.
The content should remain high-level (not to duplicate guidance). If teams ask lots of questions indicating confusion, perhaps the page needs more detail or better linking to answers.
Encourage feedback: maybe have a contact for “Questions about lifecycle stages” (like a generic digital assurance inbox).
Considering versioning: the agile phases concept is stable, but if the manual introduces say a “Discovery-lite” or other internal stage, mark when that was added.
Avoid implying that stages are strictly linear gates if DfE encourages iterative or overlapping work – reflect the actual governance style (some departments do Beta Private/Public as two sub-stages, for instance).
Continually cross-check with GDS updates (the GOV.UK Service Manual might evolve; e.g., they emphasized “continuous improvement after live”). Our manual should incorporate those best practices so teams don’t get outdated advice.
Community or Support Info
Definition: Community or Support pages provide information on communities of practice, support channels, and resources for people working in digital roles. This can include how to get help, where to ask questions, meet-ups, working groups, and points of contact for various disciplines or initiatives. Essentially, this content type connects staff to the human network and support structures beyond the documentation itself. Primary use cases:
Practitioners (designers, developers, product managers, etc.) looking to find their community of practice in DfE – for example, “Is there a content design community and how do I join?” or “Who can I ask about data standards?”.
New joiners trying to find mentoring or support – e.g., where to find guidance on tools (maybe a support page listing Slack channels, mailing lists, etc.).
Community leads who want to share what their community offers (like a page that outlines the Architecture Community’s remit, meetings, and resources
dfe-digital.github.io
).
People seeking support on processes – e.g., an accessibility support page might list how to get help with audits or issues (similar to “Support” link in accessibility manual nav
accessibility.education.gov.uk
accessibility.education.gov.uk
).
Key fields/attributes:
Title – Name of the community or support topic. E.g. “Design Community”, “User Research Community”, “Getting support for accessibility”. Could also be Q&A style like “Where to get help with user research”.
Description/Overview – A brief intro about the community or support available. For example, “The content design community is a group of content designers across DfE who share best practice and support each other”
gov.uk
.
Community scope or purpose – Explain what the community covers or its mission. E.g., “This community is for anyone who wants to discuss and learn about [discipline] in government”
gov.uk
.
Meetings/Activities – Details on any regular meet-ups, show-and-tells, or forums. For example: “Bi-weekly design meet-up every other Thursday at 2pm” or “Monthly accessibility clinic on the first Tuesday”.
Communication channels – List ways to join or contact: Slack channels (with name, e.g. “#data-community on DfE Slack”), email lists, Teams groups, etc. Make sure to note if they are internal only.
Leads or contacts – Who leads or facilitates the community (name and role, if appropriate), or specific support contacts. For support pages, this might be an email or support desk link.
Resources – Links to resources the community maintains: e.g., a link to a Confluence space, a SharePoint hub, or external websites. Architecture community page in the site links out to SharePoint and Confluence repositories
dfe-digital.github.io
; such resources can be listed here. Also, links to relevant manual sections (like if the community curates certain guidance).
FAQ – Optionally, common questions answered (this fits more in a support context, like “How do I request a…?”).
Related communities – Cross-link to other community pages if relevant (e.g. “Design and Content communities often work together; see Content Design community page”).
Join instructions – If someone needs permission or to sign up to something, provide steps (“To join the Slack channel, contact X if you’re new”; “Sign up to our mailing list here”).
Events or News – Could include upcoming event dates or link to News items tagged for that community (though events might be out-of-scope for manual, unless manually updated).
Support tools – If there are tools like “Service Health Check App” or others that are used for support, mention them (the accessibility support page likely links to the Accessibility Statement service, etc. In [17†L113-L121], they list assurance processes and tools).
Page structure guidance:
Approach like a hub page for a community. Start with a friendly introduction, maybe even first person plural (“We are the DfE design community…”).
If it’s specifically a support page rather than a broader community, make the intro task-focused (“If you need help with accessibility or have an accessibility issue to report, here’s how to get support.”).
Use subheadings for key sections:
“What we do” – summary of community purpose or support scope.
“How to get in touch” or “Join the community” – list Slack, email, etc. Possibly each as a list item with a hyperlink.
“Meetings and events” – list regular sessions or upcoming events (though manual content is static, so maybe just regular ones unless someone updates often).
“Resources” – bullet links to things like “Community SharePoint”
dfe-digital.github.io
, “Previous show and tell recordings”, or external groups (like cross-gov communities).
If this is an umbrella support page (like a generic support page for the manual), it might list various communities with brief info – but since we have separate pages per community, likely not needed.
Keep it concise and actionable – goal is user finds how to connect with real people or help. Use bullet points or short lines for contacts (they’re easier to scan than inline text).
It's okay to have a slightly more informal tone here (communities are people-driven), but still keep to clarity and avoid slang. For example, “Join our #design Slack channel to ask questions any time” is fine.
Use icons or emojis sparingly if at all (not typical in manuals, but communities sometimes use them informally – probably skip in a formal manual to stay consistent).
If including an email address, consider obfuscation if manual is public (or instruct to find on intranet if needed).
Provide any support hours or expectations if relevant (e.g. “The design support team aims to respond within 2 days” or “This is a volunteer community, so please be patient for responses”).
Interconnections:
Role ↔ Community: Role pages should point readers to their community for that profession (e.g. the User Researcher role page should say “Connect with other user researchers via the User Research community of practice” linking to it). Conversely, the community page might briefly list roles it encompasses (“Content community includes Content Designers, Technical Writers, etc.”).
News/Events ↔ Community: If the manual has News items for community updates (like “Design community conference coming up”), those can be tagged and possibly listed on the community page (“Latest news for our community: ...”). If not automated, community leads can manually add important news or event links.
Guidance ↔ Community: Some guidance might be specifically produced by a community. For example, the Accessibility community might maintain certain guidelines or a testing toolkit – those guidance pages can reference the community page (“This guidance is maintained by the accessibility community – join us [link] if you want to contribute.”).
Standards/Principles ↔ Community: Often a community owns certain standards or principles (architecture community owns architecture principles, etc.). So standard pages might list a community contact (which could link to the community page). Likewise, community page can highlight “We maintain X standards” and link to them.
Support processes: The Accessibility example stands out – the Accessibility manual had a section “Audits, issues and statements”
accessibility.education.gov.uk
. Likely a page there (“Get an accessibility audit”
accessibility.education.gov.uk
) is partly process, partly support (since it guides how to request an audit, which is done through a central team). So there is overlap: a support page might actually be written as a guidance/process page. In the unified model, either approach works, but ensure they’re findable under either category. Possibly tag support pages as guidance if they detail processes.
External communities: If DfE folks also participate in cross-government communities (like the cross-gov design community), linking out provides broader support network.
Governance notes:
Community pages should be maintained by the community leads or a designated person (like a Community Manager). Since events and contacts can change, they need ownership to keep current.
These pages might not need heavy approval beyond that community, but should remain consistent in style. A content designer might help initially to ensure clarity.
It's wise to review them periodically (maybe every 6 months) to update Slack channel info or new lead names.
If a community page is public-facing, ensure no internal-only links are exposed (or mark them as intranet-only). The current manual does present intranet links with notes (e.g. “opens DfE intranet”
standards.education.gov.uk
), which is fine as long as users know.
Communities should use these pages to welcome newcomers, so keep tone inclusive and avoid cliquish language.
If there is a central support page for the manual (like a “Support” link in the footer or nav
accessibility.education.gov.uk
 that probably goes to a generic support page or contact form), that should also be part of this content type. Possibly one “Support” page consolidates how to get help for anything related to the manual (report issues, etc.). This could list contacts for each area or a general helpdesk. This might be maintained by the Service Manual team itself.
News or Announcement
Definition: News or Announcement articles are timely updates about the Service Manual, the communities, or digital initiatives in DfE. They follow a blog/news format to inform readers of new standards, updates, events, or achievements. This content type ensures that changes and progress are communicated in an engaging, narrative form, while the rest of the manual remains more static reference material. Primary use cases:
DfE digital teams reading about the latest changes: for example, when a new standard is published or updated, a news post announces it (as seen: “Plain Language standard and guidance published”
design.education.gov.uk
).
Community members celebrating or learning about what’s new in their field (like a “Roadmap for design published” or “New version of DfE Frontend coming”
design.education.gov.uk
).
Stakeholders staying informed on the digital transformation progress (they might not read detailed guidance but will read high-level news).
Manual maintainers using news posts to highlight important additions or to drive adoption of the manual content.
Key fields/attributes:
Title – Headline of the news story, in sentence case (capitalize first word only), making it clear what the announcement is. E.g., “Plain Language standard and guidance published”
design.education.gov.uk
, “DfE Frontend 2.1.0 coming soon”
design.education.gov.uk
.
Slug – Based on title (e.g. “plain-language-standard-published”). Ensure it's short and clear.
Date – Publication date of the article
design.education.gov.uk
.
Author – Name of the author and perhaps their role
design.education.gov.uk
, if relevant. This lends transparency (e.g., it was written by the content design lead, etc.). The design manual shows author name and role
design.education.gov.uk
.
Body content – The article text, which may include:
Intro paragraph: a brief summary or hook (often what is shown on listing pages as excerpt). On GOV.UK and in DfE design news, the first paragraph typically serves this purpose
design.education.gov.uk
.
Detail: multiple paragraphs elaborating on the announcement. Keep them short (2-4 sentences each). Use subheadings if the article is long to break into sections (e.g., “Improving communication across services”
design.education.gov.uk
).
Could include bullet points for lists of changes or highlights if needed, though many news posts are narrative.
Optionally quotes or statements from key people (“John Doe, Head of X, said ‘…’”) if it’s more press-release style (less common in internal manual context but possible).
Hyperlinks to relevant content (very important to connect news to manual content). E.g., the plain language news links directly to the new standard page and related guidance
design.education.gov.uk
design.education.gov.uk
.
Images – (Optional) A lead image or thumbnail. The design manual news listing shows an image placeholder
design.education.gov.uk
 for each news item. If a relevant illustrative image or graphic is available (or even a photo from an event), it could be included. Ensure alt text. However, not critical if not readily available – content should stand on its own.
Related links – At the end, a list of related content or further reading. The example news has “Related content” listing Content design, Find and use standards, GOV.UK Style Guide
design.education.gov.uk
. This is likely curated by the author to direct readers to referenced sections or background info. In CMS, could have a field to attach related pages.
Tags – Tags or categories (possibly “News”, or topic tags like “DesignOps news” or by community). If the manual might later allow filtering news by category, tagging is useful. For example, if there are many news posts, one might filter by “Design” vs “Technical” updates. Or tag by year.
Page structure guidance:
Write news articles following GOV.UK style for news: clear, factual, but also engaging. Use active voice, and lead with the most important point (in journalism style).
Ensure the first paragraph provides the key message. For example, in the plain language news: “The DfE content design community have launched the Plain Language standard, now available on the standards product...”
design.education.gov.uk
 – it tells what happened and why it’s important in one go.
Use subheadings for structure if the article is longer than a few paragraphs. In the example, subheads like “Improving communication across services” and “A comprehensive guide for all” are used
design.education.gov.uk
design.education.gov.uk
 to break up the narrative.
Keep sentences and paragraphs short and to the point. It's a news piece, so brevity is good, but also ensure it contains enough context for someone not deeply involved.
When referring to manual content or external standards, hyperlink them inline (like they did linking GOV.UK Service Standard, style guide, etc.
design.education.gov.uk
).
You can use bold or lists to highlight key points if appropriate (for example, if announcing a new release with features, you might bullet the features).
The tone can be slightly celebratory if appropriate (like acknowledging a new milestone), but remain professional and informative.
After the main content, include a related content section if it adds value (the CMS listing of related links helps readers dive deeper). The design news uses a small list of related items at the end
design.education.gov.uk
.
End with the standard feedback widget to remain consistent with other pages (this should be automatically appended as for other content types).
Interconnections:
News → Manual content: News should always point to relevant manual pages or external references. E.g., “new standard published” news links to the standard page
design.education.gov.uk
 and guidance. “Roadmap published” news would link to the roadmap page. This drives traffic to the right content and ensures news isn’t a dead end.
Manual content → News: Generally, we don’t link backwards from a guidance to the news that announced it (since news becomes outdated). However, a “What’s new” or “News” listing is usually accessible via navigation (as we saw in design manual nav) and possibly some front-page highlights. The unified manual homepage could have a “What’s new” section summarizing latest news.
Tags: If news articles are tagged by category, one could filter to see all announcements in, say, accessibility or all announcements in past year. This is a nice-to-have for an archive.
Community ↔ News: Some news items might particularly interest a certain community (and may even be authored by community leads). For example, an architecture community update about a new principle could be both on the architecture community page and as a news. Possibly cross-post or link. The design manual’s news page states “News from the DesignOps team”
design.education.gov.uk
, implying it's mostly design community related news. In a unified manual, we might categorize news by communities (DesignOps news, ResearchOps news, etc.) or just indicate author’s area. If content is tagged by community, the community pages can list relevant news (“Recent news in this community”).
Lifecycle/Events: If a news piece is about an event or stage (like “Service assessment process updated for Beta” or “Live phase monitoring improvements”), it might tie into lifecycle stage content or processes. Possibly the news can mention and link to those updated pages.
Search: People might search for announcements of something (like “Plain language standard”). As long as the news and the content page exist, both can appear. Ensure titles and content are clear so search results make sense (the user might click either but both should guide them appropriately).
Governance notes:
The News section should be curated by the Service Manual team or communications leads within the digital team. Ideally, significant changes or launches are accompanied by a news post. It's a good practice to plan a news article whenever a new standard, pattern, or major guidance is published or updated.
Frequency: News might not be daily but aim to show regular progress (perhaps a few per month across all areas). If there’s a backlog of old news on separate manuals, consider migrating a selection to show history (or just start fresh).
Review: Because news gets dated, there’s usually no need to update old news (unless factual errors). But ensure any critical info is also reflected in permanent guidance (news shouldn’t contain unique instructions).
Authors: Encourage the actual leads to be authors for authenticity, but a content designer can help polish wording. The CMS can allow selecting an author from a list (with their role).
Approval: Probably lighter weight (a simple comms approval) compared to standards. But since news can sometimes inadvertently disclose plans or sound like official statements, a quick check by a comms person or the manual product owner is wise.
Archiving: Keep an archive of news posts accessible (by date or page numbers). This is automatically handled if the listing page just shows recent and has pagination or an archive link. The design manual shows “Read more news articles” which implies an archive listing
design.education.gov.uk
.
Align with GOV.UK style for news: While internal, maintain that clarity. Possibly avoid political or sensitive announcements on this platform – those go on official press releases. Manual news is more operational/technical.
One more link: if appropriate, link to cross-government blogs or news if relevant. For example, if GDS posts about something related, a manual news could mention “(see GDS blog post for more)” but that might be extra – focus on internal.
By defining these content types – Standard, Guidance, Pattern, Tool/Template, Process, Case Study/Design History, Role/Profession, Principle, Lifecycle Stage, Community/Support, and News – the unified DfE Service Manual can structure information in a consistent, reusable way. This model aligns with GOV.UK best practices, ensuring content is clear, well-tagged, and interconnected. Users can navigate easily: for instance, from a Standard they can jump to related Guidance, see which Roles it affects, and find Tools to comply with it. A Case Study can illustrate how a Pattern was applied in Alpha phase, linking to that Lifecycle Stage page and the Community that supported it. Governance is built-in through owners and versioning, keeping content reliable and up-to-date. Ultimately, this structured approach supports a scalable manual that grows with the DfE digital community while staying coherent and user-friendly.
dfe-digital.github.io
design-system.service.gov.uk


