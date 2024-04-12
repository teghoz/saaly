using FluentValidation;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Saaly.Data.Interfaces;
using Saaly.Data.Repositories;
using Saaly.Infrastructure.Extensions;
using Saaly.Infrastucture.Configurations;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Entity;
using Saaly.Services.Entity.BillCodes;
using Saaly.Services.Entity.BillUnits;
using Saaly.Services.Entity.Currencies;
using Saaly.Services.Recaptcha;
using Saaly.Services.Registration;
using Saaly.Services.Validators;
using Saaly.User.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var mvcBuilder = builder.Services.AddRazorPages(options =>
{
    options.Conventions.AllowAnonymousToFolder("/Identity/Account");
    options.Conventions.AllowAnonymousToAreaFolder("Identity", "/Account");
    options.Conventions.AuthorizeAreaPage("Identity", "/Accounts/Manage");
    options.Conventions.AddFolderRouteModelConvention("/App", model =>
    {
        var newSelectors = new List<SelectorModel>();
        foreach (var selector in model.Selectors)
        {
            var newSelector = new SelectorModel
            {
                AttributeRouteModel = new AttributeRouteModel
                {
                    //Template = AttributeRouteModel.CombineTemplates("/App/{entityGuid}/", selector.AttributeRouteModel.Template)
                    Template = selector.AttributeRouteModel.Template.Replace("App", "App/{entityGuid}")
                }
            };
            newSelectors.Add(newSelector);
        }

        model.Selectors.Clear();
        foreach (var newSelector in newSelectors)
        {
            model.Selectors.Add(newSelector);
        }
    });

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
        option.Cookie.Name = SaalyConfig.Instance.ProjectName + "User";
        option.LoginPath = "/Identity/Account/Login";
        option.AccessDeniedPath = "/Identity/Account/AccessDenied";
        option.SlidingExpiration = true;
    };
},
(s) =>
{
    s.AddPermissions();
});

builder.Services.AddHttpClient();
builder.Services.AddValidatorsFromAssemblyContaining<RegistrationValidator>();
builder.Services.AddScoped(typeof(IRepository<Admin>), typeof(AdminEFRepositiory));
builder.Services.AddScoped(typeof(IRepository<Entity>), typeof(EntityEFRepositiory));
builder.Services.AddScoped(typeof(IRepository<EntityUser>), typeof(EntityUserEFRepositiory));
builder.Services.AddScoped(typeof(IRepository<EntityCurrency>), typeof(EntityCurrencyEFRepositiory));
builder.Services.AddScoped(typeof(IRepository<EntityBillUnit>), typeof(EntityBillUnitEFRepositiory));
builder.Services.AddScoped(typeof(IRepository<EntityBillCode>), typeof(EntityBillCodeEFRepositiory));

builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<ICaptchaService, RecaptchaService>();
builder.Services.AddScoped<IEntityService, EntityService>();
builder.Services.AddScoped<IRegistrationService, RegistrationService>();
builder.Services.AddScoped<IEntityCurrencyService, EntityCurrencyService>();
builder.Services.AddScoped<IEntityBillUnitService, EntityBillUnitService>();
builder.Services.AddScoped<IEntityBillCodeService, EntityBillCodeService>();
builder.Services.AddScoped(x =>
{
    var actionContext = x.GetRequiredService<IActionContextAccessor>().ActionContext;
    var factory = x.GetRequiredService<IUrlHelperFactory>();
    return factory.GetUrlHelper(actionContext);
});

builder.Services.RegisterMailers();

builder.Services.AddAsyncMessaging(null, null);

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

app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
    string.Join("\n", endpointSources.SelectMany(source => source.Endpoints )));

app.Run();
