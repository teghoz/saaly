using Saaly.Extensions;
using Saaly.Infrastructure.Extensions;
using Saaly.Infrastucture.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var mvcBuilder = builder.Services.AddRazorPages(options =>
{
    options.Conventions.AllowAnonymousToFolder("/Identity/Account");
    options.Conventions.AllowAnonymousToAreaFolder("Identity", "/Account");
    options.Conventions.AuthorizeAreaPage("Identity", "/Accounts/Manage");

}).AddSessionStateTempDataProvider();

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}



builder.Services.AddSaalyContext(options =>
{
    options.ConnectionString = SaalyConfig.Instance.Database.ConnectionString;
});

builder.Services.AddCookieIdentity(options =>
{
    options.AuthenticationOptions = (option) =>
    {
        option.Cookie.HttpOnly = true;
        option.ExpireTimeSpan = TimeSpan.FromMinutes(15);
        option.Cookie.Name = SaalyConfig.Instance.ProjectName;
        option.LoginPath = "/Identity/Account/Login";
        option.AccessDeniedPath = "/Identity/Account/AccessDenied";
        option.SlidingExpiration = true;
    };
},
(s) =>
{
    s.AddPermissions();
});

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapRazorPages();
app.MapControllers();

await app.SeedUser();

app.Run();
