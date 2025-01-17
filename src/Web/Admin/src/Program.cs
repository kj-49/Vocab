

using Microsoft.EntityFrameworkCore;
using Vocab.Core.Data;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Identity;
using Vocab.Core.Features.Identity.Users;
using Vocab.Core.Features.Identity.Roles;
using Vocab.Web.Admin.Helper;
using Vocab.Core.Features;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables(prefix: "Vocab_");

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("Default"))
        .UseSnakeCaseNamingConvention();
});

builder.Services.AddIdentityServices(builder.Configuration);
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
