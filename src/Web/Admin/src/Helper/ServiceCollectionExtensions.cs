﻿using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Vocab.Core.Communication.Services;
using Vocab.Core.Data;
using Vocab.Core.Features.Identity.Roles;
using Vocab.Core.Features.Identity.Users;

namespace Vocab.Web.Admin.Helper;

public static class ServiceCollectionExtensions
{
    public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

        services.AddScoped<IEmailSender, EmailSender>();
    }
}
