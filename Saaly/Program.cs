using Saaly.Extensions;
using Saaly.Infrastructure.Extensions;
using Saaly.Infrastucture.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSaalyContext(options =>
{
    options.ConnectionString = "";
});

builder.Services.AddCookieIdentity(options =>
{
    options.AuthenticationOptions = (option) =>
    {
        option.Cookie.HttpOnly = true;
        option.ExpireTimeSpan = TimeSpan.FromMinutes(15);
        option.Cookie.Name = SaalyConfig.Instance.ProjectName;
        option.LoginPath = "/Login";
        option.AccessDeniedPath = "/Identity/Account/AccessDenied";
        option.SlidingExpiration = true;
    };
},
(s) =>
{
    s.AddPermissions();
});

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
