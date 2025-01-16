using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Vocab.Core.Communication.Services;
using Vocab.Core.Data;
using Vocab.Core.Features.Identity.Roles;
using Vocab.Core.Features.Identity.Users;
using Vocab.Web.Components.Account;

namespace Vocab.Web.Helper;

public static class ServiceCollectionExtensions
{
    public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddCascadingAuthenticationState();
        services.AddScoped<IdentityUserAccessor>();
        services.AddScoped<IdentityRedirectManager>();
        services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

        services.AddAuthentication(options =>
        {
            options.DefaultScheme = IdentityConstants.ApplicationScheme;
            options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        })
        .AddIdentityCookies();

        services.AddIdentityCore<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

        services.AddAuthentication().AddGoogle(googleOptions =>
        {
            googleOptions.ClientId = configuration["Google:ClientId"];
            googleOptions.ClientSecret = configuration["Google:ClientSecret"];
        });

        services.AddScoped<IEmailSender<AppUser>, EmailSender>();
    }
}
