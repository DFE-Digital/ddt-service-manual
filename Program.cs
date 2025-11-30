var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to use port 5066
builder.WebHost.UseUrls("http://localhost:5066");

// Add services to the container
builder.Services.AddControllersWithViews();

// Register HttpClient for DDT Standards API
builder.Services.AddHttpClient<ServiceManual.Services.DdtStandardsApiService>((IServiceProvider sp, HttpClient client) =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var baseUrl = configuration["CompassApi:BaseUrl"] ?? "http://localhost:5500";
    var accessToken = configuration["CompassApi:AccessToken"] ?? "";
    
    client.BaseAddress = new Uri(baseUrl);
    if (!string.IsNullOrEmpty(accessToken))
    {
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
    }
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

