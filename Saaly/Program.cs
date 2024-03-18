using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Saaly.Data.Interfaces;
using Saaly.Data.Repositories;
using Saaly.Extensions;
using Saaly.Infrastructure.Extensions;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;
using Saaly.Services.Admin;

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

builder.Services.AddScoped(typeof(IRepository<Admin>), typeof(AdminEFRepositiory));
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped(x =>
{
    var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
    var factory = x.GetRequiredService<IUrlHelperFactory>();
    return factory.GetUrlHelper(actionContext);
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
