

using Microsoft.EntityFrameworkCore;
using Vocab.Core.Data;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;
using Vocab.Core.Features.Identity.Users;
using Vocab.Core.Features.Identity.Roles;
using Vocab.Web.Admin.Helper;
using Vocab.Core.Features;
using Vocab.Core.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables(prefix: "Vocab_");

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(Permissions.AdminOrMaster, policy =>
        policy.RequireRole(AppRoles.Admin.ToString(), AppRoles.Master.ToString())); // Allow only Master or Admin roles
});

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/", Permissions.AdminOrMaster);
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("Default"))
        .UseSnakeCaseNamingConvention();
});

builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.LogoutPath = "/Identity/Account/Logout";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});

builder.Services.AddFeatureServices();

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
